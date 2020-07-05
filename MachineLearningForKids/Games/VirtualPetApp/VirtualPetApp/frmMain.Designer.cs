namespace VirtualPetApp
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomTextbox1 = new Bunifu.Framework.BunifuCustomTextbox();
            this.pBox_Cat = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_Dog = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Cat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Dog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(182, 70);
            this.bunifuCustomTextbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuCustomTextbox1.Multiline = true;
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(392, 65);
            this.bunifuCustomTextbox1.TabIndex = 2;
            this.bunifuCustomTextbox1.Text = "Hello Kids. Welcome to Machine Learning Application. Firstly, You should make cho" +
    "ice.";
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBox_Cat
            // 
            this.pBox_Cat.EditValue = ((object)(resources.GetObject("pBox_Cat.EditValue")));
            this.pBox_Cat.Location = new System.Drawing.Point(451, 268);
            this.pBox_Cat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_Cat.Name = "pBox_Cat";
            this.pBox_Cat.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_Cat.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_Cat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_Cat.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_Cat.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pBox_Cat.Size = new System.Drawing.Size(123, 128);
            this.pBox_Cat.TabIndex = 3;
            this.pBox_Cat.Click += new System.EventHandler(this.pBox_Cat_Click);
            // 
            // pBox_Dog
            // 
            this.pBox_Dog.EditValue = global::VirtualPetApp.Properties.Resources.dog;
            this.pBox_Dog.Location = new System.Drawing.Point(269, 268);
            this.pBox_Dog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_Dog.Name = "pBox_Dog";
            this.pBox_Dog.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_Dog.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_Dog.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_Dog.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_Dog.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pBox_Dog.Size = new System.Drawing.Size(123, 128);
            this.pBox_Dog.TabIndex = 3;
            this.pBox_Dog.Click += new System.EventHandler(this.pBox_Dog_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::VirtualPetApp.Properties.Resources.chat;
            this.pictureEdit2.Location = new System.Drawing.Point(61, 32);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(610, 176);
            this.pictureEdit2.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::VirtualPetApp.Properties.Resources.man;
            this.pictureEdit1.Location = new System.Drawing.Point(9, 223);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(154, 158);
            this.pictureEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(637, 11);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(47, 24);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "EXIT";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(706, 423);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pBox_Cat);
            this.Controls.Add(this.pBox_Dog);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Cat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Dog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pBox_Cat;
        private DevExpress.XtraEditors.PictureEdit pBox_Dog;
        private Bunifu.Framework.BunifuCustomTextbox bunifuCustomTextbox1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

