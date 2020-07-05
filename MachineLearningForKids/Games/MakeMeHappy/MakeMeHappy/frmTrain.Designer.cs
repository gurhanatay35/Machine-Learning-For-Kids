namespace MakeMeHappy
{
    partial class frmTrain
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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.lblDogspeak = new DevExpress.XtraEditors.LabelControl();
            this.txtInput = new Bunifu.Framework.BunifuCustomTextbox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_AngryFace = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_SmileFace = new DevExpress.XtraEditors.PictureEdit();
            this.btnDataAdd = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AngryFace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_SmileFace.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 24);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDogspeak
            // 
            this.lblDogspeak.Appearance.BackColor = System.Drawing.Color.White;
            this.lblDogspeak.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogspeak.Appearance.Options.UseBackColor = true;
            this.lblDogspeak.Appearance.Options.UseFont = true;
            this.lblDogspeak.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDogspeak.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lblDogspeak.Location = new System.Drawing.Point(198, 64);
            this.lblDogspeak.Margin = new System.Windows.Forms.Padding(4);
            this.lblDogspeak.Name = "lblDogspeak";
            this.lblDogspeak.Size = new System.Drawing.Size(424, 26);
            this.lblDogspeak.TabIndex = 3;
            this.lblDogspeak.Text = "Kelime yaz sonra emoji seç ve ekle";
            // 
            // txtInput
            // 
            this.txtInput.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInput.Location = new System.Drawing.Point(12, 287);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(334, 137);
            this.txtInput.TabIndex = 7;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::MakeMeHappy.Properties.Resources.DogFace;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 124);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(91, 93);
            this.pictureEdit1.TabIndex = 5;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::MakeMeHappy.Properties.Resources.chat;
            this.pictureEdit2.Location = new System.Drawing.Point(88, 23);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(673, 127);
            this.pictureEdit2.TabIndex = 6;
            // 
            // pBox_AngryFace
            // 
            this.pBox_AngryFace.EditValue = global::MakeMeHappy.Properties.Resources.redfaceemoji;
            this.pBox_AngryFace.Location = new System.Drawing.Point(617, 287);
            this.pBox_AngryFace.Name = "pBox_AngryFace";
            this.pBox_AngryFace.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_AngryFace.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_AngryFace.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_AngryFace.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pBox_AngryFace.Size = new System.Drawing.Size(144, 137);
            this.pBox_AngryFace.TabIndex = 8;
            this.pBox_AngryFace.Click += new System.EventHandler(this.pBox_AngryFace_Click);
            // 
            // pBox_SmileFace
            // 
            this.pBox_SmileFace.EditValue = global::MakeMeHappy.Properties.Resources.smile;
            this.pBox_SmileFace.Location = new System.Drawing.Point(441, 287);
            this.pBox_SmileFace.Name = "pBox_SmileFace";
            this.pBox_SmileFace.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_SmileFace.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_SmileFace.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_SmileFace.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pBox_SmileFace.Size = new System.Drawing.Size(144, 137);
            this.pBox_SmileFace.TabIndex = 8;
            this.pBox_SmileFace.Click += new System.EventHandler(this.pBox_SmileFace_Click);
            // 
            // btnDataAdd
            // 
            this.btnDataAdd.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDataAdd.Appearance.Options.UseFont = true;
            this.btnDataAdd.Location = new System.Drawing.Point(12, 460);
            this.btnDataAdd.Name = "btnDataAdd";
            this.btnDataAdd.Size = new System.Drawing.Size(749, 49);
            this.btnDataAdd.TabIndex = 9;
            this.btnDataAdd.Text = "ADD DATA";
            this.btnDataAdd.Click += new System.EventHandler(this.btnDataAdd_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(809, 534);
            this.Controls.Add(this.btnDataAdd);
            this.Controls.Add(this.pBox_SmileFace);
            this.Controls.Add(this.pBox_AngryFace);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDogspeak);
            this.Controls.Add(this.pictureEdit2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrain";
            this.Text = "frmTrain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AngryFace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_SmileFace.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.LabelControl lblDogspeak;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private Bunifu.Framework.BunifuCustomTextbox txtInput;
        private DevExpress.XtraEditors.PictureEdit pBox_AngryFace;
        private DevExpress.XtraEditors.PictureEdit pBox_SmileFace;
        private DevExpress.XtraEditors.SimpleButton btnDataAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}