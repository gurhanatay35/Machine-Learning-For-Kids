namespace VirtualPetApp
{
    partial class frmDog
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtDogspeak = new Bunifu.Framework.BunifuCustomTextbox();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_water = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_headersteak = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_night = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_glasswater = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_shower = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_exit = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_heart = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_steak = new DevExpress.XtraEditors.PictureEdit();
            this.pBox_level = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.progBar_level = new DevExpress.XtraEditors.ProgressBarControl();
            this.progBar_health = new DevExpress.XtraEditors.ProgressBarControl();
            this.progBar_water = new DevExpress.XtraEditors.ProgressBarControl();
            this.progBar_steak = new DevExpress.XtraEditors.ProgressBarControl();
            this.progBar_night = new DevExpress.XtraEditors.ProgressBarControl();
            this.pBox_bed = new DevExpress.XtraEditors.PictureEdit();
            this.timerWater = new System.Windows.Forms.Timer(this.components);
            this.timerSteak = new System.Windows.Forms.Timer(this.components);
            this.timerNight = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_water.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_headersteak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_night.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_glasswater.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_shower.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_exit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_heart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_steak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_level.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_level.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_health.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_water.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_steak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_night.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_bed.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtDogspeak
            // 
            this.txtDogspeak.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDogspeak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDogspeak.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogspeak.Location = new System.Drawing.Point(267, 202);
            this.txtDogspeak.Multiline = true;
            this.txtDogspeak.Name = "txtDogspeak";
            this.txtDogspeak.Size = new System.Drawing.Size(334, 38);
            this.txtDogspeak.TabIndex = 28;
            this.txtDogspeak.Text = "Hi.. ";
            this.txtDogspeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = global::VirtualPetApp.Properties.Resources.chat;
            this.pictureEdit5.Location = new System.Drawing.Point(181, 181);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(513, 96);
            this.pictureEdit5.TabIndex = 17;
            // 
            // pBox_water
            // 
            this.pBox_water.EditValue = global::VirtualPetApp.Properties.Resources.water;
            this.pBox_water.Location = new System.Drawing.Point(355, 30);
            this.pBox_water.Name = "pBox_water";
            this.pBox_water.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_water.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_water.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_water.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_water.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_water.Size = new System.Drawing.Size(100, 96);
            this.pBox_water.TabIndex = 18;
            // 
            // pBox_headersteak
            // 
            this.pBox_headersteak.EditValue = global::VirtualPetApp.Properties.Resources.steak;
            this.pBox_headersteak.Location = new System.Drawing.Point(227, 30);
            this.pBox_headersteak.Name = "pBox_headersteak";
            this.pBox_headersteak.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_headersteak.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_headersteak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_headersteak.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_headersteak.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_headersteak.Size = new System.Drawing.Size(100, 96);
            this.pBox_headersteak.TabIndex = 19;
            // 
            // pBox_night
            // 
            this.pBox_night.EditValue = global::VirtualPetApp.Properties.Resources.night;
            this.pBox_night.Location = new System.Drawing.Point(94, 30);
            this.pBox_night.Name = "pBox_night";
            this.pBox_night.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_night.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_night.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_night.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_night.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_night.Size = new System.Drawing.Size(100, 96);
            this.pBox_night.TabIndex = 20;
            // 
            // pBox_glasswater
            // 
            this.pBox_glasswater.EditValue = global::VirtualPetApp.Properties.Resources.glasswater;
            this.pBox_glasswater.Location = new System.Drawing.Point(355, 525);
            this.pBox_glasswater.Name = "pBox_glasswater";
            this.pBox_glasswater.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_glasswater.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_glasswater.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_glasswater.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_glasswater.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_glasswater.Size = new System.Drawing.Size(100, 96);
            this.pBox_glasswater.TabIndex = 21;
            this.pBox_glasswater.Click += new System.EventHandler(this.pBox_glasswater_Click);
            // 
            // pBox_shower
            // 
            this.pBox_shower.EditValue = global::VirtualPetApp.Properties.Resources.shower;
            this.pBox_shower.Location = new System.Drawing.Point(489, 525);
            this.pBox_shower.Name = "pBox_shower";
            this.pBox_shower.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_shower.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_shower.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_shower.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_shower.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_shower.Size = new System.Drawing.Size(100, 96);
            this.pBox_shower.TabIndex = 22;
            this.pBox_shower.Click += new System.EventHandler(this.pBox_shower_Click);
            // 
            // pBox_exit
            // 
            this.pBox_exit.EditValue = global::VirtualPetApp.Properties.Resources.door;
            this.pBox_exit.Location = new System.Drawing.Point(626, 525);
            this.pBox_exit.Name = "pBox_exit";
            this.pBox_exit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_exit.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_exit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_exit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_exit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_exit.Size = new System.Drawing.Size(100, 96);
            this.pBox_exit.TabIndex = 23;
            this.pBox_exit.Click += new System.EventHandler(this.pBox_exit_Click);
            // 
            // pBox_heart
            // 
            this.pBox_heart.EditValue = global::VirtualPetApp.Properties.Resources.heart;
            this.pBox_heart.Location = new System.Drawing.Point(489, 30);
            this.pBox_heart.Name = "pBox_heart";
            this.pBox_heart.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_heart.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_heart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_heart.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_heart.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pBox_heart.Size = new System.Drawing.Size(100, 96);
            this.pBox_heart.TabIndex = 24;
            // 
            // pBox_steak
            // 
            this.pBox_steak.EditValue = global::VirtualPetApp.Properties.Resources.et;
            this.pBox_steak.Location = new System.Drawing.Point(227, 525);
            this.pBox_steak.Name = "pBox_steak";
            this.pBox_steak.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_steak.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_steak.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_steak.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_steak.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_steak.Size = new System.Drawing.Size(100, 96);
            this.pBox_steak.TabIndex = 25;
            this.pBox_steak.Click += new System.EventHandler(this.pBox_steak_Click);
            // 
            // pBox_level
            // 
            this.pBox_level.EditValue = global::VirtualPetApp.Properties.Resources.level;
            this.pBox_level.Location = new System.Drawing.Point(626, 30);
            this.pBox_level.Name = "pBox_level";
            this.pBox_level.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_level.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_level.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_level.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_level.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_level.Size = new System.Drawing.Size(100, 96);
            this.pBox_level.TabIndex = 26;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::VirtualPetApp.Properties.Resources.dog;
            this.pictureEdit1.Location = new System.Drawing.Point(113, 283);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(234, 206);
            this.pictureEdit1.TabIndex = 16;
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 29);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(63, 29);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "BACK";
            this.simpleButton1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // progBar_level
            // 
            this.progBar_level.Location = new System.Drawing.Point(626, 135);
            this.progBar_level.Name = "progBar_level";
            this.progBar_level.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progBar_level.Properties.ShowTitle = true;
            this.progBar_level.Properties.Step = 1;
            this.progBar_level.Size = new System.Drawing.Size(100, 21);
            this.progBar_level.TabIndex = 35;
            // 
            // progBar_health
            // 
            this.progBar_health.EditValue = 100;
            this.progBar_health.Location = new System.Drawing.Point(489, 135);
            this.progBar_health.Name = "progBar_health";
            this.progBar_health.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progBar_health.Properties.ShowTitle = true;
            this.progBar_health.Properties.Step = 1;
            this.progBar_health.Size = new System.Drawing.Size(100, 21);
            this.progBar_health.TabIndex = 36;
            // 
            // progBar_water
            // 
            this.progBar_water.EditValue = 100;
            this.progBar_water.Location = new System.Drawing.Point(355, 135);
            this.progBar_water.Name = "progBar_water";
            this.progBar_water.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progBar_water.Properties.ShowTitle = true;
            this.progBar_water.Properties.Step = 1;
            this.progBar_water.Size = new System.Drawing.Size(100, 21);
            this.progBar_water.TabIndex = 37;
            // 
            // progBar_steak
            // 
            this.progBar_steak.EditValue = 100;
            this.progBar_steak.Location = new System.Drawing.Point(227, 135);
            this.progBar_steak.Name = "progBar_steak";
            this.progBar_steak.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progBar_steak.Properties.ShowTitle = true;
            this.progBar_steak.Properties.Step = 1;
            this.progBar_steak.Size = new System.Drawing.Size(100, 21);
            this.progBar_steak.TabIndex = 38;
            // 
            // progBar_night
            // 
            this.progBar_night.EditValue = 100;
            this.progBar_night.Location = new System.Drawing.Point(94, 132);
            this.progBar_night.Name = "progBar_night";
            this.progBar_night.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progBar_night.Properties.ShowTitle = true;
            this.progBar_night.Properties.Step = 1;
            this.progBar_night.Size = new System.Drawing.Size(100, 21);
            this.progBar_night.TabIndex = 39;
            // 
            // pBox_bed
            // 
            this.pBox_bed.EditValue = global::VirtualPetApp.Properties.Resources.bed;
            this.pBox_bed.Location = new System.Drawing.Point(94, 525);
            this.pBox_bed.Name = "pBox_bed";
            this.pBox_bed.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pBox_bed.Properties.Appearance.Options.UseBackColor = true;
            this.pBox_bed.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.pBox_bed.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pBox_bed.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pBox_bed.Size = new System.Drawing.Size(100, 96);
            this.pBox_bed.TabIndex = 34;
            this.pBox_bed.Click += new System.EventHandler(this.pBox_bed_Click);
            // 
            // timerWater
            // 
            this.timerWater.Tick += new System.EventHandler(this.timerWater_Tick);
            // 
            // timerSteak
            // 
            this.timerSteak.Tick += new System.EventHandler(this.timerSteak_Tick);
            // 
            // timerNight
            // 
            this.timerNight.Tick += new System.EventHandler(this.timerNight_Tick);
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(804, 652);
            this.Controls.Add(this.progBar_level);
            this.Controls.Add(this.progBar_health);
            this.Controls.Add(this.progBar_water);
            this.Controls.Add(this.progBar_steak);
            this.Controls.Add(this.progBar_night);
            this.Controls.Add(this.pBox_bed);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDogspeak);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.pBox_water);
            this.Controls.Add(this.pBox_headersteak);
            this.Controls.Add(this.pBox_night);
            this.Controls.Add(this.pBox_glasswater);
            this.Controls.Add(this.pBox_shower);
            this.Controls.Add(this.pBox_exit);
            this.Controls.Add(this.pBox_heart);
            this.Controls.Add(this.pBox_steak);
            this.Controls.Add(this.pBox_level);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDog";
            this.Text = "frmDog";
            this.Load += new System.EventHandler(this.frmDog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_water.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_headersteak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_night.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_glasswater.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_shower.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_exit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_heart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_steak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_level.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_level.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_health.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_water.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_steak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBar_night.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_bed.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.BunifuCustomTextbox txtDogspeak;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.PictureEdit pBox_water;
        private DevExpress.XtraEditors.PictureEdit pBox_headersteak;
        private DevExpress.XtraEditors.PictureEdit pBox_night;
        private DevExpress.XtraEditors.PictureEdit pBox_glasswater;
        private DevExpress.XtraEditors.PictureEdit pBox_shower;
        private DevExpress.XtraEditors.PictureEdit pBox_exit;
        private DevExpress.XtraEditors.PictureEdit pBox_heart;
        private DevExpress.XtraEditors.PictureEdit pBox_steak;
        private DevExpress.XtraEditors.PictureEdit pBox_level;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ProgressBarControl progBar_level;
        private DevExpress.XtraEditors.ProgressBarControl progBar_health;
        private DevExpress.XtraEditors.ProgressBarControl progBar_water;
        private DevExpress.XtraEditors.ProgressBarControl progBar_steak;
        private DevExpress.XtraEditors.ProgressBarControl progBar_night;
        private DevExpress.XtraEditors.PictureEdit pBox_bed;
        private System.Windows.Forms.Timer timerWater;
        private System.Windows.Forms.Timer timerSteak;
        private System.Windows.Forms.Timer timerNight;
    }
}