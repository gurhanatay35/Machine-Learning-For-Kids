namespace KiwiorStoat
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confidenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoloItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_open = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.grd_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_close = new System.Windows.Forms.Label();
            this.btn_detect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoloItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.grd_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrid
            // 
            this.dtgrid.AutoGenerateColumns = false;
            this.dtgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.confidenceDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn});
            this.dtgrid.DataSource = this.yoloItemBindingSource;
            this.dtgrid.GridColor = System.Drawing.Color.Black;
            this.dtgrid.Location = new System.Drawing.Point(12, 393);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.Size = new System.Drawing.Size(643, 158);
            this.dtgrid.TabIndex = 1;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // confidenceDataGridViewTextBoxColumn
            // 
            this.confidenceDataGridViewTextBoxColumn.DataPropertyName = "Confidence";
            this.confidenceDataGridViewTextBoxColumn.HeaderText = "Confidence";
            this.confidenceDataGridViewTextBoxColumn.Name = "confidenceDataGridViewTextBoxColumn";
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // yoloItemBindingSource
            // 
            this.yoloItemBindingSource.DataSource = typeof(Alturos.Yolo.Model.YoloItem);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(12, 49);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(695, 338);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grd_panel_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grd_panel_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grd_panel_MouseUp);
            // 
            // btn_open
            // 
            this.btn_open.AllowToggling = false;
            this.btn_open.AnimationSpeed = 200;
            this.btn_open.AutoGenerateColors = false;
            this.btn_open.BackColor = System.Drawing.Color.Transparent;
            this.btn_open.BackColor1 = System.Drawing.Color.White;
            this.btn_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_open.BackgroundImage")));
            this.btn_open.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_open.ButtonText = "Aç";
            this.btn_open.ButtonTextMarginLeft = 0;
            this.btn_open.ColorContrastOnClick = 45;
            this.btn_open.ColorContrastOnHover = 45;
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_open.CustomizableEdges = borderEdges1;
            this.btn_open.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_open.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_open.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_open.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_open.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_open.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.IconMarginLeft = 11;
            this.btn_open.IconPadding = 10;
            this.btn_open.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.IdleBorderColor = System.Drawing.Color.Black;
            this.btn_open.IdleBorderRadius = 1;
            this.btn_open.IdleBorderThickness = 1;
            this.btn_open.IdleFillColor = System.Drawing.Color.White;
            this.btn_open.IdleIconLeftImage = null;
            this.btn_open.IdleIconRightImage = null;
            this.btn_open.IndicateFocus = false;
            this.btn_open.Location = new System.Drawing.Point(751, 90);
            this.btn_open.Name = "btn_open";
            this.btn_open.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_open.OnDisabledState.BorderRadius = 1;
            this.btn_open.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_open.OnDisabledState.BorderThickness = 1;
            this.btn_open.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_open.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_open.OnDisabledState.IconLeftImage = null;
            this.btn_open.OnDisabledState.IconRightImage = null;
            this.btn_open.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_open.onHoverState.BorderRadius = 1;
            this.btn_open.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_open.onHoverState.BorderThickness = 1;
            this.btn_open.onHoverState.FillColor = System.Drawing.Color.Aquamarine;
            this.btn_open.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_open.onHoverState.IconLeftImage = null;
            this.btn_open.onHoverState.IconRightImage = null;
            this.btn_open.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btn_open.OnIdleState.BorderRadius = 1;
            this.btn_open.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_open.OnIdleState.BorderThickness = 1;
            this.btn_open.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn_open.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_open.OnIdleState.IconLeftImage = null;
            this.btn_open.OnIdleState.IconRightImage = null;
            this.btn_open.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btn_open.OnPressedState.BorderRadius = 1;
            this.btn_open.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_open.OnPressedState.BorderThickness = 1;
            this.btn_open.OnPressedState.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_open.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_open.OnPressedState.IconLeftImage = null;
            this.btn_open.OnPressedState.IconRightImage = null;
            this.btn_open.Size = new System.Drawing.Size(119, 61);
            this.btn_open.TabIndex = 4;
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_open.TextMarginLeft = 0;
            this.btn_open.UseDefaultRadiusAndThickness = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // grd_panel
            // 
            this.grd_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grd_panel.BackgroundImage")));
            this.grd_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grd_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grd_panel.Controls.Add(this.lbl_close);
            this.grd_panel.GradientBottomLeft = System.Drawing.Color.White;
            this.grd_panel.GradientBottomRight = System.Drawing.Color.White;
            this.grd_panel.GradientTopLeft = System.Drawing.Color.White;
            this.grd_panel.GradientTopRight = System.Drawing.Color.White;
            this.grd_panel.Location = new System.Drawing.Point(0, 0);
            this.grd_panel.Name = "grd_panel";
            this.grd_panel.Quality = 10;
            this.grd_panel.Size = new System.Drawing.Size(900, 30);
            this.grd_panel.TabIndex = 5;
            this.grd_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grd_panel_MouseDown);
            this.grd_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grd_panel_MouseMove);
            this.grd_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grd_panel_MouseUp);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.BackColor = System.Drawing.Color.White;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(871, 2);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(24, 24);
            this.lbl_close.TabIndex = 6;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // btn_detect
            // 
            this.btn_detect.AllowToggling = false;
            this.btn_detect.AnimationSpeed = 200;
            this.btn_detect.AutoGenerateColors = false;
            this.btn_detect.BackColor = System.Drawing.Color.Transparent;
            this.btn_detect.BackColor1 = System.Drawing.Color.White;
            this.btn_detect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_detect.BackgroundImage")));
            this.btn_detect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_detect.ButtonText = "Tanı";
            this.btn_detect.ButtonTextMarginLeft = 0;
            this.btn_detect.ColorContrastOnClick = 45;
            this.btn_detect.ColorContrastOnHover = 45;
            this.btn_detect.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_detect.CustomizableEdges = borderEdges2;
            this.btn_detect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_detect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_detect.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_detect.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_detect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_detect.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detect.ForeColor = System.Drawing.Color.Black;
            this.btn_detect.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detect.IconMarginLeft = 11;
            this.btn_detect.IconPadding = 10;
            this.btn_detect.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detect.IdleBorderColor = System.Drawing.Color.Black;
            this.btn_detect.IdleBorderRadius = 1;
            this.btn_detect.IdleBorderThickness = 1;
            this.btn_detect.IdleFillColor = System.Drawing.Color.White;
            this.btn_detect.IdleIconLeftImage = null;
            this.btn_detect.IdleIconRightImage = null;
            this.btn_detect.IndicateFocus = false;
            this.btn_detect.Location = new System.Drawing.Point(751, 178);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_detect.OnDisabledState.BorderRadius = 1;
            this.btn_detect.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_detect.OnDisabledState.BorderThickness = 1;
            this.btn_detect.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_detect.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_detect.OnDisabledState.IconLeftImage = null;
            this.btn_detect.OnDisabledState.IconRightImage = null;
            this.btn_detect.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_detect.onHoverState.BorderRadius = 1;
            this.btn_detect.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btn_detect.onHoverState.BorderThickness = 1;
            this.btn_detect.onHoverState.FillColor = System.Drawing.Color.Aquamarine;
            this.btn_detect.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_detect.onHoverState.IconLeftImage = null;
            this.btn_detect.onHoverState.IconRightImage = null;
            this.btn_detect.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btn_detect.OnIdleState.BorderRadius = 1;
            this.btn_detect.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_detect.OnIdleState.BorderThickness = 1;
            this.btn_detect.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn_detect.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_detect.OnIdleState.IconLeftImage = null;
            this.btn_detect.OnIdleState.IconRightImage = null;
            this.btn_detect.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btn_detect.OnPressedState.BorderRadius = 1;
            this.btn_detect.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_detect.OnPressedState.BorderThickness = 1;
            this.btn_detect.OnPressedState.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btn_detect.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_detect.OnPressedState.IconLeftImage = null;
            this.btn_detect.OnPressedState.IconRightImage = null;
            this.btn_detect.Size = new System.Drawing.Size(119, 61);
            this.btn_detect.TabIndex = 4;
            this.btn_detect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_detect.TextMarginLeft = 0;
            this.btn_detect.UseDefaultRadiusAndThickness = true;
            this.btn_detect.Visible = false;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.grd_panel);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.dtgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiwiorStoat";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoloItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.grd_panel.ResumeLayout(false);
            this.grd_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confidenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource yoloItemBindingSource;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_open;
        private Bunifu.Framework.UI.BunifuGradientPanel grd_panel;
        private System.Windows.Forms.Label lbl_close;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_detect;
    }
}

