namespace geziBul
{
    partial class frmSecim
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
            this.btnUlke = new DevExpress.XtraEditors.SimpleButton();
            this.btnTur = new DevExpress.XtraEditors.SimpleButton();
            this.checkedUlke = new System.Windows.Forms.CheckedListBox();
            this.checkedTur = new System.Windows.Forms.CheckedListBox();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnUlke
            // 
            this.btnUlke.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUlke.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.btnUlke.Appearance.Options.UseFont = true;
            this.btnUlke.Appearance.Options.UseForeColor = true;
            this.btnUlke.Location = new System.Drawing.Point(672, 231);
            this.btnUlke.Name = "btnUlke";
            this.btnUlke.Size = new System.Drawing.Size(95, 30);
            this.btnUlke.TabIndex = 0;
            this.btnUlke.Text = "Ülkeye Göre Bul";
            this.btnUlke.Click += new System.EventHandler(this.btnUlke_Click);
            // 
            // btnTur
            // 
            this.btnTur.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTur.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.btnTur.Appearance.Options.UseFont = true;
            this.btnTur.Appearance.Options.UseForeColor = true;
            this.btnTur.Location = new System.Drawing.Point(672, 380);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(95, 30);
            this.btnTur.TabIndex = 1;
            this.btnTur.Text = "Türe Göre Bul";
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // checkedUlke
            // 
            this.checkedUlke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkedUlke.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.checkedUlke.ForeColor = System.Drawing.Color.Gold;
            this.checkedUlke.FormattingEnabled = true;
            this.checkedUlke.Location = new System.Drawing.Point(612, 264);
            this.checkedUlke.Name = "checkedUlke";
            this.checkedUlke.Size = new System.Drawing.Size(229, 118);
            this.checkedUlke.TabIndex = 2;
            this.checkedUlke.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedTur
            // 
            this.checkedTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkedTur.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.checkedTur.ForeColor = System.Drawing.Color.Gold;
            this.checkedTur.FormattingEnabled = true;
            this.checkedTur.Location = new System.Drawing.Point(612, 264);
            this.checkedTur.Name = "checkedTur";
            this.checkedTur.Size = new System.Drawing.Size(229, 118);
            this.checkedTur.TabIndex = 3;
            this.checkedTur.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.Location = new System.Drawing.Point(672, 571);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 30);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Devam";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 45.25F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gezi Rehberim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1170, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.Appearance.Options.UseForeColor = true;
            this.btnCikis.Location = new System.Drawing.Point(1365, 615);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 30);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 651);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.checkedTur);
            this.Controls.Add(this.checkedUlke);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnUlke);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim";
            this.Load += new System.EventHandler(this.frmSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedUlke;
        private System.Windows.Forms.CheckedListBox checkedTur;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btnUlke;
        public DevExpress.XtraEditors.SimpleButton btnTur;
        public DevExpress.XtraEditors.SimpleButton btnNext;
        public System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}