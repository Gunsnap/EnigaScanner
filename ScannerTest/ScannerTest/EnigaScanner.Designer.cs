namespace ScannerTest {
	partial class EnigaScanner {
		/// <summary> Required designer variable. </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> Clean up any resources being used. </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && (components != null) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.cbLokation = new System.Windows.Forms.ComboBox();
			this.tbLokation = new System.Windows.Forms.TextBox();
			this.lblInitialer = new System.Windows.Forms.Label();
			this.tbInitialer = new System.Windows.Forms.TextBox();
			this.btnSletRaekke = new System.Windows.Forms.Button();
			this.lblStregkoderne = new System.Windows.Forms.Label();
			this.lblLokationerne = new System.Windows.Forms.Label();
			this.lblDatoerne = new System.Windows.Forms.Label();
			this.lblModelerne = new System.Windows.Forms.Label();
			this.tbStregkoderne = new System.Windows.Forms.TextBox();
			this.tbLokationerne = new System.Windows.Forms.TextBox();
			this.tbDatoerne = new System.Windows.Forms.TextBox();
			this.tbModellerne = new System.Windows.Forms.TextBox();
			this.btnUdfyld = new System.Windows.Forms.Button();
			this.btnNulstil = new System.Windows.Forms.Button();
			this.btnGemXlsx = new System.Windows.Forms.Button();
			this.btnGemTxt = new System.Windows.Forms.Button();
			this.tlpData = new System.Windows.Forms.TableLayoutPanel();
			this.lblInitialerne = new System.Windows.Forms.Label();
			this.tbInitialerne = new System.Windows.Forms.TextBox();
			this.tlpData.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbLokation
			// 
			this.cbLokation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLokation.FormattingEnabled = true;
			this.cbLokation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbLokation.Items.AddRange( new object[] {
			"Andet",
			"LAU",
			"NBV",
			"SJV"} );
			this.cbLokation.Location = new System.Drawing.Point( 10 , 13 );
			this.cbLokation.Name = "cbLokation";
			this.cbLokation.Size = new System.Drawing.Size( 121 , 21 );
			this.cbLokation.TabIndex = 1;
			this.cbLokation.SelectedIndexChanged += new System.EventHandler( this.cbLokation_SelectedIndexChanged );
			// 
			// tbLokation
			// 
			this.tbLokation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLokation.Location = new System.Drawing.Point( 137 , 13 );
			this.tbLokation.Name = "tbLokation";
			this.tbLokation.Size = new System.Drawing.Size( 333 , 20 );
			this.tbLokation.TabIndex = 2;
			this.tbLokation.Text = "Vælg en lokation!";
			// 
			// lblInitialer
			// 
			this.lblInitialer.AutoSize = true;
			this.lblInitialer.Location = new System.Drawing.Point( 10 , 44 );
			this.lblInitialer.Name = "lblInitialer";
			this.lblInitialer.Size = new System.Drawing.Size( 43 , 13 );
			this.lblInitialer.TabIndex = 0;
			this.lblInitialer.Text = "Initialer:";
			// 
			// tbInitialer
			// 
			this.tbInitialer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbInitialer.Location = new System.Drawing.Point( 60 , 41 );
			this.tbInitialer.Name = "tbInitialer";
			this.tbInitialer.Size = new System.Drawing.Size( 71 , 20 );
			this.tbInitialer.TabIndex = 3;
			// 
			// btnSletRaekke
			// 
			this.btnSletRaekke.Location = new System.Drawing.Point( 137 , 40 );
			this.btnSletRaekke.Name = "btnSletRaekke";
			this.btnSletRaekke.Size = new System.Drawing.Size( 75 , 23 );
			this.btnSletRaekke.TabIndex = 4;
			this.btnSletRaekke.Text = "Slet række";
			this.btnSletRaekke.UseVisualStyleBackColor = true;
			this.btnSletRaekke.Click += new System.EventHandler( this.btnSletRaekke_Click );
			// 
			// lblStregkoderne
			// 
			this.lblStregkoderne.AutoSize = true;
			this.lblStregkoderne.Location = new System.Drawing.Point( 3 , 0 );
			this.lblStregkoderne.Name = "lblStregkoderne";
			this.lblStregkoderne.Size = new System.Drawing.Size( 56 , 13 );
			this.lblStregkoderne.TabIndex = 0;
			this.lblStregkoderne.Text = "Stregkode";
			// 
			// lblLokationerne
			// 
			this.lblLokationerne.AutoSize = true;
			this.lblLokationerne.Location = new System.Drawing.Point( 95 , 0 );
			this.lblLokationerne.Name = "lblLokationerne";
			this.lblLokationerne.Size = new System.Drawing.Size( 48 , 13 );
			this.lblLokationerne.TabIndex = 5;
			this.lblLokationerne.Text = "Lokation";
			// 
			// lblDatoerne
			// 
			this.lblDatoerne.AutoSize = true;
			this.lblDatoerne.Location = new System.Drawing.Point( 187 , 0 );
			this.lblDatoerne.Name = "lblDatoerne";
			this.lblDatoerne.Size = new System.Drawing.Size( 30 , 13 );
			this.lblDatoerne.TabIndex = 5;
			this.lblDatoerne.Text = "Dato";
			// 
			// lblModelerne
			// 
			this.lblModelerne.AutoSize = true;
			this.lblModelerne.Location = new System.Drawing.Point( 279 , 0 );
			this.lblModelerne.Name = "lblModelerne";
			this.lblModelerne.Size = new System.Drawing.Size( 36 , 13 );
			this.lblModelerne.TabIndex = 5;
			this.lblModelerne.Text = "Model";
			// 
			// tbStregkoderne
			// 
			this.tbStregkoderne.AcceptsReturn = true;
			this.tbStregkoderne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				  | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.tbStregkoderne.Location = new System.Drawing.Point( 3 , 16 );
			this.tbStregkoderne.Name = "tbStregkoderne";
			this.tbStregkoderne.Size = new System.Drawing.Size( 86 , 20 );
			this.tbStregkoderne.TabIndex = 4;
			this.tbStregkoderne.WordWrap = false;
			this.tbStregkoderne.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.tb_KeyPress );
			this.tbStregkoderne.Leave += new System.EventHandler( this.tb_Leave );
			// 
			// tbLokationerne
			// 
			this.tbLokationerne.AcceptsReturn = true;
			this.tbLokationerne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				  | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLokationerne.Location = new System.Drawing.Point( 95 , 16 );
			this.tbLokationerne.Name = "tbLokationerne";
			this.tbLokationerne.Size = new System.Drawing.Size( 86 , 20 );
			this.tbLokationerne.TabIndex = 5;
			this.tbLokationerne.WordWrap = false;
			this.tbLokationerne.Leave += new System.EventHandler( this.tb_Leave );
			// 
			// tbDatoerne
			// 
			this.tbDatoerne.AcceptsReturn = true;
			this.tbDatoerne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				  | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDatoerne.Location = new System.Drawing.Point( 187 , 16 );
			this.tbDatoerne.Name = "tbDatoerne";
			this.tbDatoerne.Size = new System.Drawing.Size( 86 , 20 );
			this.tbDatoerne.TabIndex = 6;
			this.tbDatoerne.WordWrap = false;
			this.tbDatoerne.Leave += new System.EventHandler( this.tb_Leave );
			// 
			// tbModellerne
			// 
			this.tbModellerne.AcceptsReturn = true;
			this.tbModellerne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				  | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.tbModellerne.Location = new System.Drawing.Point( 279 , 16 );
			this.tbModellerne.Name = "tbModellerne";
			this.tbModellerne.Size = new System.Drawing.Size( 86 , 20 );
			this.tbModellerne.TabIndex = 7;
			this.tbModellerne.WordWrap = false;
			this.tbModellerne.Leave += new System.EventHandler( this.tb_Leave );
			// 
			// btnUdfyld
			// 
			this.btnUdfyld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUdfyld.Location = new System.Drawing.Point( 10 , 286 );
			this.btnUdfyld.Name = "btnUdfyld";
			this.btnUdfyld.Size = new System.Drawing.Size( 463 , 25 );
			this.btnUdfyld.TabIndex = 2;
			this.btnUdfyld.TabStop = false;
			this.btnUdfyld.Text = "Udfyld data";
			this.btnUdfyld.UseVisualStyleBackColor = true;
			this.btnUdfyld.Click += new System.EventHandler( this.btnUdfyld_Click );
			// 
			// btnNulstil
			// 
			this.btnNulstil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNulstil.Location = new System.Drawing.Point( 10 , 311 );
			this.btnNulstil.Name = "btnNulstil";
			this.btnNulstil.Size = new System.Drawing.Size( 463 , 25 );
			this.btnNulstil.TabIndex = 0;
			this.btnNulstil.TabStop = false;
			this.btnNulstil.Text = "Nulstil app";
			this.btnNulstil.UseVisualStyleBackColor = true;
			this.btnNulstil.Click += new System.EventHandler( this.btnNulstil_Click );
			// 
			// btnGemXlsx
			// 
			this.btnGemXlsx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGemXlsx.Location = new System.Drawing.Point( 10 , 336 );
			this.btnGemXlsx.Name = "btnGemXlsx";
			this.btnGemXlsx.Size = new System.Drawing.Size( 463 , 25 );
			this.btnGemXlsx.TabIndex = 0;
			this.btnGemXlsx.TabStop = false;
			this.btnGemXlsx.Text = "Gem som excel fil";
			this.btnGemXlsx.UseVisualStyleBackColor = true;
			this.btnGemXlsx.Click += new System.EventHandler( this.ClickGem );
			// 
			// btnGemTxt
			// 
			this.btnGemTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGemTxt.Location = new System.Drawing.Point( 10 , 361 );
			this.btnGemTxt.Name = "btnGemTxt";
			this.btnGemTxt.Size = new System.Drawing.Size( 463 , 25 );
			this.btnGemTxt.TabIndex = 0;
			this.btnGemTxt.TabStop = false;
			this.btnGemTxt.Text = "Gem som txt fil";
			this.btnGemTxt.UseVisualStyleBackColor = true;
			this.btnGemTxt.Click += new System.EventHandler( this.ClickGem );
			// 
			// tlpData
			// 
			this.tlpData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				  | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpData.AutoScroll = true;
			this.tlpData.ColumnCount = 5;
			this.tlpData.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent , 20F ) );
			this.tlpData.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent , 20F ) );
			this.tlpData.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent , 20F ) );
			this.tlpData.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent , 20F ) );
			this.tlpData.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent , 20F ) );
			this.tlpData.Controls.Add( this.lblStregkoderne , 0 , 0 );
			this.tlpData.Controls.Add( this.lblLokationerne , 1 , 0 );
			this.tlpData.Controls.Add( this.lblDatoerne , 2 , 0 );
			this.tlpData.Controls.Add( this.lblModelerne , 3 , 0 );
			this.tlpData.Controls.Add( this.lblInitialerne , 4 , 0 );
			this.tlpData.Controls.Add( this.tbStregkoderne , 0 , 1 );
			this.tlpData.Controls.Add( this.tbLokationerne , 1 , 1 );
			this.tlpData.Controls.Add( this.tbDatoerne , 2 , 1 );
			this.tlpData.Controls.Add( this.tbModellerne , 3 , 1 );
			this.tlpData.Controls.Add( this.tbInitialerne , 4 , 1 );
			this.tlpData.Location = new System.Drawing.Point( 10 , 67 );
			this.tlpData.Name = "tlpData";
			this.tlpData.RowCount = 3;
			this.tlpData.RowStyles.Add( new System.Windows.Forms.RowStyle() );
			this.tlpData.RowStyles.Add( new System.Windows.Forms.RowStyle() );
			this.tlpData.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute , 20F ) );
			this.tlpData.Size = new System.Drawing.Size( 461 , 213 );
			this.tlpData.TabIndex = 0;
			// 
			// lblInitialerne
			// 
			this.lblInitialerne.AutoSize = true;
			this.lblInitialerne.Location = new System.Drawing.Point( 371 , 0 );
			this.lblInitialerne.Name = "lblInitialerne";
			this.lblInitialerne.Size = new System.Drawing.Size( 40 , 13 );
			this.lblInitialerne.TabIndex = 8;
			this.lblInitialerne.Text = "Initialer";
			// 
			// tbInitialerne
			// 
			this.tbInitialerne.AcceptsReturn = true;
			this.tbInitialerne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				  | System.Windows.Forms.AnchorStyles.Left)
				  | System.Windows.Forms.AnchorStyles.Right)));
			this.tbInitialerne.Location = new System.Drawing.Point( 371 , 16 );
			this.tbInitialerne.Name = "tbInitialerne";
			this.tbInitialerne.Size = new System.Drawing.Size( 87 , 20 );
			this.tbInitialerne.TabIndex = 9;
			this.tbInitialerne.WordWrap = false;
			// 
			// EnigaScanner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 483 , 396 );
			this.Controls.Add( this.cbLokation );
			this.Controls.Add( this.tbLokation );
			this.Controls.Add( this.lblInitialer );
			this.Controls.Add( this.tbInitialer );
			this.Controls.Add( this.btnSletRaekke );
			this.Controls.Add( this.tlpData );
			this.Controls.Add( this.btnUdfyld );
			this.Controls.Add( this.btnNulstil );
			this.Controls.Add( this.btnGemXlsx );
			this.Controls.Add( this.btnGemTxt );
			this.MinimumSize = new System.Drawing.Size( 450 , 300 );
			this.Name = "EnigaScanner";
			this.Padding = new System.Windows.Forms.Padding( 10 );
			this.Text = "Eniga Scanner (Alfa)";
			this.tlpData.ResumeLayout( false );
			this.tlpData.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbLokation;

		private System.Windows.Forms.TableLayoutPanel tlpData;

		private System.Windows.Forms.Label lblStregkoderne;
		private System.Windows.Forms.Label lblLokationerne;
		private System.Windows.Forms.Label lblDatoerne;
		private System.Windows.Forms.Label lblModelerne;
		private System.Windows.Forms.Label lblInitialer;

		private System.Windows.Forms.TextBox tbInitialer;
		private System.Windows.Forms.TextBox tbLokation;
		private System.Windows.Forms.TextBox tbStregkoderne;
		private System.Windows.Forms.TextBox tbDatoerne;
		private System.Windows.Forms.TextBox tbLokationerne;
		private System.Windows.Forms.TextBox tbModellerne;

		private System.Windows.Forms.Button btnGemTxt;
		private System.Windows.Forms.Button btnNulstil;
		private System.Windows.Forms.Button btnGemXlsx;
		private System.Windows.Forms.Button btnUdfyld;
		private System.Windows.Forms.Button btnSletRaekke;
		private System.Windows.Forms.TextBox tbInitialerne;
		private System.Windows.Forms.Label lblInitialerne;
	}
}