namespace MakeMeHappy
{
    partial class frmTest
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
            this.lblDogspeak = new DevExpress.XtraEditors.LabelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.txtInput = new DevExpress.XtraEditors.TextEdit();
            this.bntControl = new DevExpress.XtraEditors.SimpleButton();
            this.pBoxFaces = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFaces.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDogspeak
            // 
            this.lblDogspeak.Appearance.BackColor = System.Drawing.Color.White;
            this.lblDogspeak.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogspeak.Appearance.Options.UseBackColor = true;
            this.lblDogspeak.Appearance.Options.UseFont = true;
            this.lblDogspeak.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDogspeak.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lblDogspeak.Location = new System.Drawing.Point(142, 74);
            this.lblDogspeak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDogspeak.Name = "lblDogspeak";
            this.lblDogspeak.Size = new System.Drawing.Size(230, 26);
            this.lblDogspeak.TabIndex = 0;
            this.lblDogspeak.Text = "Write to word my friends.";
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 24);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 310);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(737, 20);
            this.txtInput.TabIndex = 4;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // bntControl
            // 
            this.bntControl.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntControl.Appearance.Options.UseFont = true;
            this.bntControl.Location = new System.Drawing.Point(12, 346);
            this.bntControl.Name = "bntControl";
            this.bntControl.Size = new System.Drawing.Size(737, 50);
            this.bntControl.TabIndex = 5;
            this.bntControl.Text = "CONTROL";
            this.bntControl.Click += new System.EventHandler(this.bntControl_Click);
            // 
            // pBoxFaces
            // 
            this.pBoxFaces.Location = new System.Drawing.Point(452, 31);
            this.pBoxFaces.Name = "pBoxFaces";
            this.pBoxFaces.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBoxFaces.Properties.Appearance.Options.UseBackColor = true;
            this.pBoxFaces.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBoxFaces.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBoxFaces.Size = new System.Drawing.Size(297, 213);
            this.pBoxFaces.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::MakeMeHappy.Properties.Resources.DogFace;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 151);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(91, 93);
            this.pictureEdit1.TabIndex = 2;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::MakeMeHappy.Properties.Resources.chat;
            this.pictureEdit2.Location = new System.Drawing.Point(96, 31);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(313, 127);
            this.pictureEdit2.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(762, 429);
            this.Controls.Add(this.bntControl);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.pBoxFaces);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDogspeak);
            this.Controls.Add(this.pictureEdit2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFaces.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDogspeak;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pBoxFaces;
        private DevExpress.XtraEditors.TextEdit txtInput;
        private DevExpress.XtraEditors.SimpleButton bntControl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}