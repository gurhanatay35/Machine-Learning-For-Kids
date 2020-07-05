namespace schLibrary
{
    partial class frmSonuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblKitapTur = new System.Windows.Forms.Label();
            this.lblKitapSayfa = new System.Windows.Forms.Label();
            this.lblKitapKonu = new System.Windows.Forms.Label();
            this.lblKitapYayinEvi = new System.Windows.Forms.Label();
            this.lblKitapYazar = new System.Windows.Forms.Label();
            this.lblKitapBegeni = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1377, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1377, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1377, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(250, 586);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 37);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Yeni Kitap Getir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(1187, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 168);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.lblKitapAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblKitapAdi.Location = new System.Drawing.Point(60, 24);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(356, 76);
            this.lblKitapAdi.TabIndex = 5;
            this.lblKitapAdi.Text = "ad";
            // 
            // lblKitapTur
            // 
            this.lblKitapTur.AutoSize = true;
            this.lblKitapTur.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKitapTur.Location = new System.Drawing.Point(214, 321);
            this.lblKitapTur.Name = "lblKitapTur";
            this.lblKitapTur.Size = new System.Drawing.Size(35, 13);
            this.lblKitapTur.TabIndex = 6;
            this.lblKitapTur.Text = "label4";
            // 
            // lblKitapSayfa
            // 
            this.lblKitapSayfa.AutoSize = true;
            this.lblKitapSayfa.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKitapSayfa.Location = new System.Drawing.Point(214, 368);
            this.lblKitapSayfa.Name = "lblKitapSayfa";
            this.lblKitapSayfa.Size = new System.Drawing.Size(35, 13);
            this.lblKitapSayfa.TabIndex = 7;
            this.lblKitapSayfa.Text = "label4";
            this.lblKitapSayfa.Click += new System.EventHandler(this.lblKitapSayfa_Click);
            // 
            // lblKitapKonu
            // 
            this.lblKitapKonu.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.lblKitapKonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblKitapKonu.Location = new System.Drawing.Point(60, 120);
            this.lblKitapKonu.Name = "lblKitapKonu";
            this.lblKitapKonu.Size = new System.Drawing.Size(711, 183);
            this.lblKitapKonu.TabIndex = 8;
            this.lblKitapKonu.Text = "label4";
            this.lblKitapKonu.Click += new System.EventHandler(this.lblKitapKonu_Click);
            // 
            // lblKitapYayinEvi
            // 
            this.lblKitapYayinEvi.AutoSize = true;
            this.lblKitapYayinEvi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKitapYayinEvi.Location = new System.Drawing.Point(214, 413);
            this.lblKitapYayinEvi.Name = "lblKitapYayinEvi";
            this.lblKitapYayinEvi.Size = new System.Drawing.Size(35, 13);
            this.lblKitapYayinEvi.TabIndex = 9;
            this.lblKitapYayinEvi.Text = "label4";
            // 
            // lblKitapYazar
            // 
            this.lblKitapYazar.AutoSize = true;
            this.lblKitapYazar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKitapYazar.Location = new System.Drawing.Point(214, 463);
            this.lblKitapYazar.Name = "lblKitapYazar";
            this.lblKitapYazar.Size = new System.Drawing.Size(35, 13);
            this.lblKitapYazar.TabIndex = 10;
            this.lblKitapYazar.Text = "label4";
            // 
            // lblKitapBegeni
            // 
            this.lblKitapBegeni.AutoSize = true;
            this.lblKitapBegeni.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKitapBegeni.Location = new System.Drawing.Point(214, 515);
            this.lblKitapBegeni.Name = "lblKitapBegeni";
            this.lblKitapBegeni.Size = new System.Drawing.Size(35, 13);
            this.lblKitapBegeni.TabIndex = 11;
            this.lblKitapBegeni.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(52, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kitabın Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(52, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(52, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Yayın Evi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(52, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Yazar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(52, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Beğenilme Oranı";
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.Appearance.Options.UseForeColor = true;
            this.btnCikis.Location = new System.Drawing.Point(534, 586);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(98, 37);
            this.btnCikis.TabIndex = 21;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(65, 586);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(115, 37);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Tür Değiştir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 662);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKitapBegeni);
            this.Controls.Add(this.lblKitapYazar);
            this.Controls.Add(this.lblKitapYayinEvi);
            this.Controls.Add(this.lblKitapKonu);
            this.Controls.Add(this.lblKitapSayfa);
            this.Controls.Add(this.lblKitapTur);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSonuc";
            this.Text = "frmSonuc";
            this.Load += new System.EventHandler(this.frmSonuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblKitapTur;
        private System.Windows.Forms.Label lblKitapSayfa;
        private System.Windows.Forms.Label lblKitapKonu;
        private System.Windows.Forms.Label lblKitapYayinEvi;
        private System.Windows.Forms.Label lblKitapYazar;
        private System.Windows.Forms.Label lblKitapBegeni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}