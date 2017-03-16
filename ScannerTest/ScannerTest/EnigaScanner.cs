using System;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScannerTest {
  public partial class EnigaScanner : Form {
    char[] alfabetet = "abcdefghijklmnopqrstuvwxyzæøå".ToCharArray();
    byte antalKolonner = 5;

    // Hvor filen skal gemmes
    string placering;

    // Samlinger af data
    string[] stregkodeArr;
    string[] lokationArr;
    DateTime[] datoArr;
    string[] initialerArr;
    string[] modelArr;

    public EnigaScanner() {
      InitializeComponent();

      // Find brugerens skrivebord, så der kan gemmes der.
      placering = Environment.GetFolderPath( Environment.SpecialFolder.DesktopDirectory );

      cbLokation.SelectedIndex = 0;

      stregkodeArr = new string[] { };
      lokationArr = new string[] { };
      datoArr = new DateTime[] { };
      initialerArr = new string[] { };
      modelArr = new string[] { };
    }

    private void btnNulstil_Click( object sender, EventArgs e ) {
      NulstilApp();
    }

    /// <summary> Nulstilling af app </summary>
    private void NulstilApp( bool ogsåStregkoder = true ) {
      if( ogsåStregkoder ) {
        tbStregkoderne.Clear();
        while( SletNeddersteRaekke() ) { }
      }

      tbLokationerne.Clear();
      tbDatoerne.Clear();
      tbModellerne.Clear();

      tbStregkoderne.Focus();
    }

    //FIXME skal hente fra alle rækker
    /// <summary> Gemmer inputtet. </summary>
    private void ClickGem( object sender, EventArgs e ) {
      Button knap = (Button)sender;
      char returKode = 'ø';

      // Hvis nedderste række er tom fjernes den.
      if( ( (TextBox)tlpData.Controls[ tlpData.Controls.Count - antalKolonner ] ).Text == "" )
        SletNeddersteRaekke();

      // Stregkoder
      stregkodeArr = tbStregkoderne.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries );

      // Lokationer
      //lokationArr = tbLokationer.Text.Split( newLine.ToCharArray(), StringSplitOptions.None );
      FyldArray( ref lokationArr, stregkodeArr.Length, tbLokationerne );

      // Dato
      string[] tmpDatoArr = tbDatoerne.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries );
      for( int i = 0 ; i < tmpDatoArr.Length ; i++ ) {
        datoArr[ i ] = DateTime.Parse( tmpDatoArr[ i ] );
      }

      // Initialer
      initialerArr = tbInitialer.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.None );

      // Initialer
      modelArr = tbModellerne.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.None );

      // Bestem hvor der skal gemmes
      if( knap.Name == "btnGemTxt" )
        returKode = GemSomTxt();
      else if( knap.Name == "btnGemXlsx" )
        returKode = GemSomXlsx();

      if( returKode == '1' ) {
        MessageBox.Show( "Gemt." );
        TextBox stregkodeTb = (TextBox)tlpData.Controls[ tlpData.Controls.Count - 4 ];
        stregkodeTb.Focus();
        stregkodeTb.Select( tbStregkoderne.TextLength, 0 );
        return;
      }

      MessageBox.Show( "Kunne ikke gemmes.", "Fejlkode:\n" + returKode );
    }

    /// <summary> Gemmer til .txt </summary>
    private char GemSomTxt() {
      char returKode = '0';

      FileStream fs = new FileStream( placering + "\\Test.txt", FileMode.OpenOrCreate, FileAccess.Write );
      StreamWriter sw = new StreamWriter( fs );

      try {
        // Start i slutningen af dokumentet
        sw.BaseStream.Seek( 0, SeekOrigin.End );

        // Tilføj alle dataerne
        sw.WriteLine( "stregkodeArr"
            + "\t" + "lokationArr"
            + "\t" + "datoArr"
            + "\t\t" + "modelArr"
            + "\t" + "initialerArr"
            );
        for( int i = 0 ; i < stregkodeArr.Length ; i++ ) {
          sw.WriteLine( stregkodeArr[ i ]
            + "\t" + lokationArr[ i ]
            + "\t" + datoArr[ i ]
            + "\t" + modelArr[ i ]
            + "\t" + initialerArr[ i ]
            );
        }

        returKode = '1';
      }
      catch( Exception ) {
        returKode = 'Ø';
      }
      finally {
        sw.Flush();
        sw.Close();
        fs.Close();
      }

      return returKode;
    }

    /// <summary> Gemmer til .xlsx </summary>
    private char GemSomXlsx() {
      char retur = '0';
      int laengde = stregkodeArr.Length + 1;

      // Start Excel i baggrunden (skjuler Excel mens det kører)
      Excel.Application xApp = new Excel.Application() { Visible = false, UserControl = false };

      // Tilføj en ny workbook
      Excel._Workbook xWB = xApp.Workbooks.Add( "" );

      // Tilføj et ark
      Excel._Worksheet xArk = (Excel._Worksheet)xWB.ActiveSheet;

      // Gør klar til brug af forskellige mængder data
      Excel.Range xRange;
      object misvalue = System.Reflection.Missing.Value;

      try {
        // Skriv tabel headers samt formatér til fed og centreret
        string[] overskrifter = { "Stregkode", "Nuv. lokation", "Dato" , "Initialer" , "Model" };
        char sidsteBogstav = alfabetet[ overskrifter.Length - 1 ];
        xRange = xArk.get_Range( "A1", sidsteBogstav + "1" );

        xRange.Value2 = overskrifter;
        xRange.Font.Bold = true;
        xRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

        // Stregkoder
        string[,] stregkoderne = new string[ stregkodeArr.Length, 1 ];
        for( int i = 0 ; i < stregkodeArr.Length ; i++ ) {
          stregkoderne[ i, 0 ] = stregkodeArr[ i ];
        }
        xArk.get_Range( "A2", "A" + laengde ).Value2 = stregkoderne;

        // Nuværende lokation
        //FIXME lokationArr skal ikke sættes her, kun bruges!!
        lokationArr = tbLokationerne.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries );
        string[,] lokationer = new string[ lokationArr.Length, 1 ];
        for( int i = 0 ; i < lokationArr.Length ; i++ ) {
          lokationer[ i, 0 ] = lokationArr[ i ];
        }
        xArk.get_Range( "B2", "B" + laengde ).Value2 = lokationer;

        //FIXME Dato skal tages fra datoArr!!
        xRange = xArk.get_Range( "C2", "C" + laengde );
        xRange.Formula = DateTime.Now;
        xRange.EntireColumn.NumberFormat = "DD/MM/YYY";

        // Initialer
        xArk.get_Range( "D2", "D" + laengde ).Formula = initialerArr;

        //FIXME Model skal ikke sættes her!!
        modelArr = tbModellerne.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries );
        string[,] modeller = new string[ modelArr.Length, 1 ];
        for( int i = 0 ; i < modelArr.Length ; i++ ) {
          modeller[ i, 0 ] = modelArr[ i ];
        }
        xArk.get_Range( "E2", "E" + laengde ).Value2 = modeller;

        // AutoFit kolonne A:E
        xArk.get_Range( "A1", sidsteBogstav + "1" ).EntireColumn.AutoFit();

        // Hvor der skal gemmes
        //TODO spørg bruger om placering
        string filPlacering = placering + "\\ES " + DateTime.Now.ToShortDateString() + ".xlsx";

        //FIXME undersøg om filen findes; hvis den gør tilføjes eventuelt klokkeslet

        // Gem
        xWB.SaveAs( filPlacering, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
            false, false, Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing );

        // Fortæl at det lykkedes
        retur = '1';
      }
      catch( Exception ) {
        retur = 'Ø';
        // Gem ikke eventuelle ændringer.
        xWB.Close( false );
      }
      finally {
        xApp.Workbooks.Close();
        xApp.Application.Quit();
        xApp.Quit();
      }

      return retur;
    }

    /// <summary> Hvis der vælges "Andet" vises en TextBox så der kan indtastes. </summary>
    private void cbLokation_SelectedIndexChanged( object sender, EventArgs e ) {
      ComboBox cb = (ComboBox)sender;

      tbLokation.Text = cb.Text;

      if( cb.SelectedItem.ToString() == "Andet" ) {
        tbLokation.Visible = true;
        tbLokation.Focus();
      } else {
        tbLokation.Visible = false;
        tbInitialer.Focus();
      }
    }

    /// <summary> Udfylder data ud fra bl.a. antallet af stregkoder. </summary>
    private void btnUdfyld_Click( object sender, EventArgs e ) {
      // Gem hvad der er nu
      stregkodeArr = tbStregkoderne.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries );

      // Længden på alt
      int lengde = stregkodeArr.Length;

      // Lokationer
      FyldArray( ref lokationArr, lengde, tbLokationerne, tbLokation );

      //FIXME Datoer
      datoArr = new DateTime[ lengde ];
      for( int i = 0 ; i < lengde ; i++ ) {
        datoArr[ i ] = DateTime.Now;
      }

      // Initialer
      FyldArray( ref initialerArr, lengde, null, tbInitialer );

      // Modeler
      FyldArray( ref modelArr, lengde, tbModellerne );

      // Gør klar til opdaterede data
      NulstilApp( false );

      // Udfyld de opdaterede data
      for( int i = 0 ; i < stregkodeArr.Length ; i++ ) {
        // Sørg for at der ikke kommer en ekstra linje i bunden af hver liste
        string nyLinje = NyLinje( i, stregkodeArr.Length );

        tbLokationerne.Text += lokationArr[ i ] + nyLinje;
        tbDatoerne.Text += string.Format( "{0:d}", datoArr[ i ].Date ) + nyLinje;
        tbModellerne.Text += modelArr[ i ] + nyLinje;
      }
    }
    
    //FIXME se på hvorfor data kommer ud som UKENDT ved .txt
    /// <summary> Udfylder det valgte array </summary>
    private void FyldArray( ref string[] arr, int lengde, TextBox tbGammel, TextBox tb = null ) {
      // Sæt længden til at passe
      arr = new string[ lengde ];

      if( tb == null ) {
        tb = new TextBox();
        tb.Text = "";
      }

      // Fyld alle de gamle data ind igen
      for( int i = 0 ; i < lengde ; i++ ) {
        arr[ i ] = ( tb.Text != "" ) ? tb.Text : "UKENDT";
      }
    }

    private void FyldArrayNy( ref string[] arr, int lengde, TextBox tbGammel, TextBox tb = null ) {
      // Sæt længden til at passe
      arr = new string[ lengde ];

      if( tb == null ) {
        tb = new TextBox();
        tb.Text = "";
      }

      // Fyld alle de gamle data ind igen
      for( int i = 0 ; i < lengde ; i++ ) {
        arr[ i ] = ( tb.Text != "" ) ? tb.Text : "UKENDT";
      }
    }

    /// <summary> Når der forlades en TextBox skal dataen gemmes. </summary>
    private void tb_Leave( object sender, EventArgs e ) {
      if( sender.GetType() != typeof( TextBox ) )
        return;

      TextBox senderTB = (TextBox)sender;

      // Opret et midlertidigt array ud fra TextBoxen.
      string[] tmpArr;
      if( senderTB.Name == "tbStregkoderne" )
        tmpArr = senderTB.Text.Split( Environment.NewLine.ToCharArray(), StringSplitOptions.None );
      else {
        tmpArr = new string[ stregkodeArr.Length ];
        //FIXME loop over alle relevante TextBoxe
      }

      if( senderTB.Name != tbStregkoderne.Name ) {
        tmpArr = FjernTommeLinjer( tmpArr, true );

        switch( senderTB.Name ) {
          case "tbLokationerne":
            SetTextBox( tmpArr, ref tbLokationerne, tbLokation.Text );//FIXME, sidste skal ikke sættes her
            lokationArr = tmpArr;
            break;
          case "tbDatoerne":
            SetTextBox( tmpArr, ref tbDatoerne );
            datoArr = new DateTime[ stregkodeArr.Length ];
            for( int i = 0 ; i < tmpArr.Length ; i++ ) {
              if( !DateTime.TryParse( tmpArr[ i ], out datoArr[ i ] ) ) {
                datoArr[ i ] = DateTime.MinValue;
              }
            }
            break;
          case "tbModellerne":
            SetTextBox( tmpArr, ref tbModellerne );
            break;
          default:
            return;
        }

        // Hvis ikke alle data er udfyldt skal brugeren punkes.
        if( FjernTommeLinjer( tmpArr ).Length != stregkodeArr.Length )
          MessageBox.Show( "Udfyld venligst alle data.\nKlik eventuelt på \"" + btnUdfyld.Text + "\"" );

        return;
      }

      // ** Understående sker kun ved tbStregkoder **\\
      stregkodeArr = FjernTommeLinjer( tmpArr );
      senderTB.Clear();
      for( int i = 0 ; i < stregkodeArr.Length ; i++ ) {
        senderTB.Text += stregkodeArr[ i ] + NyLinje( i, stregkodeArr.Length );
      }
    }

    private void SetTextBox( string[] tmpArr, ref TextBox tmpTB, string tbNy = null ) {
      tmpTB.Clear();

      for( int i = 0 ; i < stregkodeArr.Length ; i++ ) {
        string tmpStr = "";
        try {
          tmpStr = tmpArr[ i ];
        }
        catch( Exception exe ) {
          MessageBox.Show( "FEJL:\n" + exe.Message );
        }

        // Sæt standarten ind de steder hvor der mangler (hvis leveret)
        if( tbNy != null && tmpStr == "" )
          tmpStr = tbNy;

        // Sæt ind og sørg for at der ikke kommer en ekstra linje i bunden
        tmpTB.Text += tmpStr + NyLinje( i, stregkodeArr.Length );
      }
    }

    /// <summary> Retunerer en ny linje hvis "nu" er forskellig fra "til - 1". </summary>
    private string NyLinje( int nu, int til ) {
      return ( nu == til - 1 ? "" : Environment.NewLine );
    }

    /// <summary> Retunerer inputtet uden tomme linjer.
    /// <para> Hvis "hverAnden = true" slettes hver anden linje.
    /// Dette er for at eventuelt tomme reelle linjer kan udfyldes senere. </para></summary>
    private string[] FjernTommeLinjer( string[] udgangspunkt, bool hverAnden = false ) {
      string[] retur;
      int længde = hverAnden ? stregkodeArr.Length : udgangspunkt.Length;

      // Sæt længden af retur
      int count = 0;
      if( hverAnden )
        count = længde;
      else
        foreach( string str in udgangspunkt ) {
          if( str != "" )
            count++;
        }
      retur = new string[ count ];

      // Udfyld retur
      int j = 0;
      for( int i = 0 ; i < længde ; i++ ) {
        if( hverAnden ) {
          try {
            retur[ j ] = udgangspunkt[ i * 2 ];
            j++;
          }
          catch( Exception ) {
            retur[ j ] = "";//FIXME Er der behov for tryCatch?
            j++;
          }
        } else if( udgangspunkt[ i ] != "" ) {
          retur[ j ] = udgangspunkt[ i ];
          j++;
        }
      }

      return retur;
    }

    /// <summary> Kalder SletNeddersteRaekke(). </summary>
    private void btnSletRaekke_Click( object sender, EventArgs e ) {
      SletNeddersteRaekke();
    }

    /// <summary> Sletter den nedderste række. </summary>
    private bool SletNeddersteRaekke() {
      // Hvis det er den sidste række må den ikke slettes!
      if( tlpData.Controls[ tlpData.Controls.Count - ( antalKolonner + 1 ) ].GetType() == typeof( Label ) )
        return false;

      for( int i = 0 ; i < antalKolonner ; i++ ) {
        tlpData.Controls.RemoveAt( tlpData.Controls.Count - 1 );
      }

      return true;
    }

    /// <summary> Tilføjer en række nedderst. </summary>
    private void TilfoejRaekke() {
      //tlpData.Controls.AddRange( new Control[] { NyTextBox(), NyTextBox(), NyTextBox(), NyTextBox(), NyTextBox() } );

      TextBox stregkodeBoks = NyTextBox();
      stregkodeBoks.Name = "tbStregkode";
      tlpData.Controls.Add( stregkodeBoks );


      for( int i = 0 ; i < antalKolonner-1 ; i++ ) {
        tlpData.Controls.Add( NyTextBox() );
      }
      var first = tlpData.Controls[ tlpData.Controls.Count - antalKolonner ];
      first.KeyPress += tb_KeyPress;
      first.Focus();
    }

    private static TextBox NyTextBox( bool multi = false, bool fyld = true ) {
      TextBox retur = new TextBox() { Multiline = multi };
      retur.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      return retur;
    }

    /// <summary> Ved linjeskift tilføjes en ny række. </summary>
    private void tb_KeyPress( object sender, KeyPressEventArgs e ) {
      if( e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return )
        TilfoejRaekke();
    }

  }
}