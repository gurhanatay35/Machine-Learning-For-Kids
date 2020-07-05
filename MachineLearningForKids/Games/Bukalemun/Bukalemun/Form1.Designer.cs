namespace Bukalemun
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.imageVisible = new System.Windows.Forms.PictureBox();
            this.lbl_exit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_file_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageChange = new System.Windows.Forms.PictureBox();
            this.btnChoose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnChoose);
            this.bunifuGradientPanel1.Controls.Add(this.imageVisible);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_exit);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_file_name);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.imageChange);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Tomato;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkMagenta;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkTurquoise;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 477);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Visible = false;
            // 
            // imageVisible
            // 
            this.imageVisible.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.imageVisible, BunifuAnimatorNS.DecorationType.None);
            this.imageVisible.Image = global::Bukalemun.Properties.Resources.bukalemun_white;
            this.imageVisible.Location = new System.Drawing.Point(583, 81);
            this.imageVisible.Name = "imageVisible";
            this.imageVisible.Size = new System.Drawing.Size(137, 124);
            this.imageVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageVisible.TabIndex = 7;
            this.imageVisible.TabStop = false;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.White;
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lbl_exit, BunifuAnimatorNS.DecorationType.None);
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exit.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_exit.Location = new System.Drawing.Point(770, 6);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(24, 24);
            this.lbl_exit.TabIndex = 0;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbl_file_name, BunifuAnimatorNS.DecorationType.None);
            this.lbl_file_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_file_name.ForeColor = System.Drawing.Color.White;
            this.lbl_file_name.Location = new System.Drawing.Point(12, 448);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_file_name.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Bukalemun.Properties.Resources.bukalemun_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(423, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // imageChange
            // 
            this.imageChange.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.imageChange, BunifuAnimatorNS.DecorationType.None);
            this.imageChange.Location = new System.Drawing.Point(12, 42);
            this.imageChange.Name = "imageChange";
            this.imageChange.Size = new System.Drawing.Size(494, 396);
            this.imageChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageChange.TabIndex = 2;
            this.imageChange.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Active = false;
            this.btnChoose.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.btnChoose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoose.BorderRadius = 7;
            this.btnChoose.ButtonText = "Resim Seçiniz";
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnChoose, BunifuAnimatorNS.DecorationType.None);
            this.btnChoose.DisabledColor = System.Drawing.Color.Gray;
            this.btnChoose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChoose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChoose.Iconimage")));
            this.btnChoose.Iconimage_right = null;
            this.btnChoose.Iconimage_right_Selected = null;
            this.btnChoose.Iconimage_Selected = null;
            this.btnChoose.IconMarginLeft = 0;
            this.btnChoose.IconMarginRight = 0;
            this.btnChoose.IconRightVisible = true;
            this.btnChoose.IconRightZoom = 0D;
            this.btnChoose.IconVisible = false;
            this.btnChoose.IconZoom = 90D;
            this.btnChoose.IsTab = false;
            this.btnChoose.Location = new System.Drawing.Point(549, 244);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnChoose.OnHovercolor = System.Drawing.Color.BlueViolet;
            this.btnChoose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChoose.selected = false;
            this.btnChoose.Size = new System.Drawing.Size(206, 52);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Resim Seçiniz";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoose.Textcolor = System.Drawing.Color.White;
            this.btnChoose.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChoose.Click += new System.EventHandler(this.renkBul);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 36);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bukalemun";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_exit;
        private Bunifu.Framework.UI.BunifuFlatButton btnChoose;
        private System.Windows.Forms.PictureBox imageChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_file_name;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imageVisible;
    }
}

