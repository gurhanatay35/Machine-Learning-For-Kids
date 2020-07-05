namespace FaceLock
{
    partial class Phone
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_exit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_train_project = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FaceLock.Properties.Resources.phone;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exit.ForeColor = System.Drawing.Color.White;
            this.lbl_exit.Location = new System.Drawing.Point(348, 10);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(24, 24);
            this.lbl_exit.TabIndex = 22;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // btn_train_project
            // 
            this.btn_train_project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_train_project.FlatAppearance.BorderSize = 0;
            this.btn_train_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_train_project.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_train_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_train_project.ForeColor = System.Drawing.Color.White;
            this.btn_train_project.IconChar = FontAwesome.Sharp.IconChar.PhoneAlt;
            this.btn_train_project.IconColor = System.Drawing.Color.White;
            this.btn_train_project.IconSize = 32;
            this.btn_train_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_train_project.Location = new System.Drawing.Point(0, -1);
            this.btn_train_project.Name = "btn_train_project";
            this.btn_train_project.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_train_project.Rotation = 0D;
            this.btn_train_project.Size = new System.Drawing.Size(380, 48);
            this.btn_train_project.TabIndex = 23;
            this.btn_train_project.Text = "Telefon";
            this.btn_train_project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_train_project.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_train_project.UseVisualStyleBackColor = false;
            this.btn_train_project.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.btn_train_project.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.btn_train_project.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 718);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.btn_train_project);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone";
            this.Load += new System.EventHandler(this.Phone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_exit;
        private FontAwesome.Sharp.IconButton btn_train_project;
    }
}