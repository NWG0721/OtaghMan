namespace OtaghMan.App.Forms
{
    partial class frmMain
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
            AltoControls.AltoButton btnHeader;
            this.panHead = new System.Windows.Forms.Panel();
            this.wiLBiTRoundedPictureBox21 = new WiLBiT.WiLBiTRoundedPictureBox2();
            this.btnMinimize = new AltoControls.AltoButton();
            this.btnExit = new AltoControls.AltoButton();
            this.panMenu = new System.Windows.Forms.Panel();
            this.tableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.wiLBiTGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            btnHeader = new AltoControls.AltoButton();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiLBiTRoundedPictureBox21)).BeginInit();
            this.tableGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.Transparent;
            this.panHead.Controls.Add(btnHeader);
            this.panHead.Controls.Add(this.wiLBiTRoundedPictureBox21);
            this.panHead.Controls.Add(this.btnMinimize);
            this.panHead.Controls.Add(this.btnExit);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(1160, 35);
            this.panHead.TabIndex = 1;
            // 
            // btnHeader
            // 
            btnHeader.Active1 = System.Drawing.Color.Transparent;
            btnHeader.Active2 = System.Drawing.Color.Transparent;
            btnHeader.BackColor = System.Drawing.Color.Transparent;
            btnHeader.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            btnHeader.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            btnHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            btnHeader.Inactive1 = System.Drawing.Color.Transparent;
            btnHeader.Inactive2 = System.Drawing.Color.Transparent;
            btnHeader.Location = new System.Drawing.Point(35, 0);
            btnHeader.Name = "btnHeader";
            btnHeader.Radius = 10;
            btnHeader.Size = new System.Drawing.Size(1055, 35);
            btnHeader.Stroke = false;
            btnHeader.StrokeColor = System.Drawing.Color.Gray;
            btnHeader.TabIndex = 4;
            btnHeader.Text = "Otagh-e Man";
            btnHeader.Transparency = false;
            // 
            // wiLBiTRoundedPictureBox21
            // 
            this.wiLBiTRoundedPictureBox21.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.wiLBiTRoundedPictureBox21.BorderColor = System.Drawing.Color.RoyalBlue;
            this.wiLBiTRoundedPictureBox21.BorderColor2 = System.Drawing.Color.HotPink;
            this.wiLBiTRoundedPictureBox21.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.wiLBiTRoundedPictureBox21.BorderSize = 2;
            this.wiLBiTRoundedPictureBox21.Dock = System.Windows.Forms.DockStyle.Left;
            this.wiLBiTRoundedPictureBox21.GradientAngle = 50F;
            this.wiLBiTRoundedPictureBox21.Location = new System.Drawing.Point(0, 0);
            this.wiLBiTRoundedPictureBox21.Name = "wiLBiTRoundedPictureBox21";
            this.wiLBiTRoundedPictureBox21.Size = new System.Drawing.Size(35, 35);
            this.wiLBiTRoundedPictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wiLBiTRoundedPictureBox21.TabIndex = 1;
            this.wiLBiTRoundedPictureBox21.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnMinimize.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimize.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMinimize.Location = new System.Drawing.Point(1090, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Radius = 10;
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.Stroke = false;
            this.btnMinimize.StrokeColor = System.Drawing.Color.Gray;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Transparency = false;
            // 
            // btnExit
            // 
            this.btnExit.Active1 = System.Drawing.Color.Red;
            this.btnExit.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Inactive1 = System.Drawing.Color.Red;
            this.btnExit.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(1125, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 10;
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.Stroke = false;
            this.btnExit.StrokeColor = System.Drawing.Color.Gray;
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "✕";
            this.btnExit.Transparency = false;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 35);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1160, 48);
            this.panMenu.TabIndex = 2;
            // 
            // tableGrid
            // 
            this.tableGrid.AutoScroll = true;
            this.tableGrid.ColumnCount = 9;
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.Controls.Add(this.wiLBiTGradientPanel1, 7, 1);
            this.tableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGrid.Location = new System.Drawing.Point(0, 83);
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.RowCount = 5;
            this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableGrid.Size = new System.Drawing.Size(1160, 597);
            this.tableGrid.TabIndex = 3;
            // 
            // wiLBiTGradientPanel1
            // 
            this.wiLBiTGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.wiLBiTGradientPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.wiLBiTGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.wiLBiTGradientPanel1.BorderRadius = 20;
            this.wiLBiTGradientPanel1.BorderSize = 2;
            this.wiLBiTGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiLBiTGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.wiLBiTGradientPanel1.Location = new System.Drawing.Point(872, 8);
            this.wiLBiTGradientPanel1.Name = "wiLBiTGradientPanel1";
            this.wiLBiTGradientPanel1.Size = new System.Drawing.Size(277, 285);
            this.wiLBiTGradientPanel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1160, 680);
            this.Controls.Add(this.tableGrid);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.panHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wiLBiTRoundedPictureBox21)).EndInit();
            this.tableGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private WiLBiT.WiLBiTRoundedPictureBox2 wiLBiTRoundedPictureBox21;
        private AltoControls.AltoButton btnMinimize;
        private AltoControls.AltoButton btnExit;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.TableLayoutPanel tableGrid;
        private WiLBiT.WiLBiTGradientPanel wiLBiTGradientPanel1;
    }
}