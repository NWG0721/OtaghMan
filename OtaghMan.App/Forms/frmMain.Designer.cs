﻿namespace OtaghMan.App
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
            this.picAppIcon = new WiLBiT.WiLBiTRoundedPictureBox2();
            this.btnMinimize = new AltoControls.AltoButton();
            this.btnExit = new AltoControls.AltoButton();
            this.panMenu = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.panRoom = new WiLBiT.WiLBiTGradientPanel();
            this.btnOpenRoom = new WiLBiT.WiLBiTButton();
            this.btnManageRoom = new WiLBiT.WiLBiTButton();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.panContaner = new System.Windows.Forms.Panel();
            this.panAddnewRoom = new WiLBiT.WiLBiTGradientPanel();
            this.btnAddnewRoom = new AltoControls.AltoButton();
            btnHeader = new AltoControls.AltoButton();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            this.panMenu.SuspendLayout();
            this.panRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            this.panContaner.SuspendLayout();
            this.panAddnewRoom.SuspendLayout();
            this.SuspendLayout();
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
            btnHeader.Size = new System.Drawing.Size(747, 35);
            btnHeader.Stroke = false;
            btnHeader.StrokeColor = System.Drawing.Color.Gray;
            btnHeader.TabIndex = 4;
            btnHeader.Text = "Otagh-e Man";
            btnHeader.Transparency = false;
            btnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.Transparent;
            this.panHead.Controls.Add(btnHeader);
            this.panHead.Controls.Add(this.picAppIcon);
            this.panHead.Controls.Add(this.btnMinimize);
            this.panHead.Controls.Add(this.btnExit);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(852, 35);
            this.panHead.TabIndex = 1;
            // 
            // picAppIcon
            // 
            this.picAppIcon.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAppIcon.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAppIcon.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAppIcon.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picAppIcon.BorderSize = 2;
            this.picAppIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAppIcon.GradientAngle = 50F;
            this.picAppIcon.Location = new System.Drawing.Point(0, 0);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Size = new System.Drawing.Size(35, 35);
            this.picAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppIcon.TabIndex = 1;
            this.picAppIcon.TabStop = false;
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
            this.btnMinimize.Location = new System.Drawing.Point(782, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Radius = 10;
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.Stroke = false;
            this.btnMinimize.StrokeColor = System.Drawing.Color.Gray;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Transparency = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnExit.Location = new System.Drawing.Point(817, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 10;
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.Stroke = false;
            this.btnExit.StrokeColor = System.Drawing.Color.Gray;
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "✕";
            this.btnExit.Transparency = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panMenu.Controls.Add(this.splitter3);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 35);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(852, 48);
            this.panMenu.TabIndex = 2;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(852, 52);
            this.splitter3.TabIndex = 9;
            this.splitter3.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(802, 83);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(50, 556);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(0, 83);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(50, 556);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(50, 83);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(752, 60);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter5.Enabled = false;
            this.splitter5.Location = new System.Drawing.Point(50, 579);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(752, 60);
            this.splitter5.TabIndex = 8;
            this.splitter5.TabStop = false;
            // 
            // panRoom
            // 
            this.panRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.panRoom.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panRoom.BorderColor = System.Drawing.Color.Peru;
            this.panRoom.BorderRadius = 15;
            this.panRoom.BorderSize = 2;
            this.panRoom.Controls.Add(this.btnOpenRoom);
            this.panRoom.Controls.Add(this.btnManageRoom);
            this.panRoom.Controls.Add(this.lblOwner);
            this.panRoom.Controls.Add(this.lblRoomName);
            this.panRoom.Controls.Add(this.picRoom);
            this.panRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRoom.ForeColor = System.Drawing.Color.Peru;
            this.panRoom.Location = new System.Drawing.Point(552, 0);
            this.panRoom.Name = "panRoom";
            this.panRoom.Size = new System.Drawing.Size(383, 419);
            this.panRoom.TabIndex = 4;
            // 
            // btnOpenRoom
            // 
            this.btnOpenRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnOpenRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnOpenRoom.BorderRadius = 15;
            this.btnOpenRoom.BorderSize = 2;
            this.btnOpenRoom.FlatAppearance.BorderSize = 0;
            this.btnOpenRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnOpenRoom.Location = new System.Drawing.Point(6, 354);
            this.btnOpenRoom.Name = "btnOpenRoom";
            this.btnOpenRoom.Size = new System.Drawing.Size(169, 51);
            this.btnOpenRoom.TabIndex = 5;
            this.btnOpenRoom.Text = "بازکردن";
            this.btnOpenRoom.UseVisualStyleBackColor = false;
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnManageRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnManageRoom.BorderRadius = 15;
            this.btnManageRoom.BorderSize = 2;
            this.btnManageRoom.FlatAppearance.BorderSize = 0;
            this.btnManageRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnManageRoom.Location = new System.Drawing.Point(208, 354);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnManageRoom.Size = new System.Drawing.Size(169, 51);
            this.btnManageRoom.TabIndex = 5;
            this.btnManageRoom.Text = "مدیریت";
            this.btnManageRoom.UseVisualStyleBackColor = false;
            this.btnManageRoom.Click += new System.EventHandler(this.lblManageRoom_Click);
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblOwner.Location = new System.Drawing.Point(278, 303);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(86, 25);
            this.lblOwner.TabIndex = 4;
            this.lblOwner.Text = "مال فلانی";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRoomName.Location = new System.Drawing.Point(313, 247);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(43, 25);
            this.lblRoomName.TabIndex = 3;
            this.lblRoomName.Text = "اتاق";
            // 
            // picRoom
            // 
            this.picRoom.BackColor = System.Drawing.Color.Silver;
            this.picRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.picRoom.Location = new System.Drawing.Point(0, 0);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(383, 228);
            this.picRoom.TabIndex = 1;
            this.picRoom.TabStop = false;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter6.Enabled = false;
            this.splitter6.Location = new System.Drawing.Point(533, 0);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(19, 419);
            this.splitter6.TabIndex = 9;
            this.splitter6.TabStop = false;
            // 
            // panContaner
            // 
            this.panContaner.AutoScroll = true;
            this.panContaner.AutoScrollMargin = new System.Drawing.Size(100, 10);
            this.panContaner.AutoScrollMinSize = new System.Drawing.Size(50, 10);
            this.panContaner.Controls.Add(this.panAddnewRoom);
            this.panContaner.Controls.Add(this.splitter6);
            this.panContaner.Controls.Add(this.panRoom);
            this.panContaner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContaner.Location = new System.Drawing.Point(50, 143);
            this.panContaner.Name = "panContaner";
            this.panContaner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panContaner.Size = new System.Drawing.Size(752, 436);
            this.panContaner.TabIndex = 11;
            // 
            // panAddnewRoom
            // 
            this.panAddnewRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(203)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.panAddnewRoom.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(60)))));
            this.panAddnewRoom.BorderColor = System.Drawing.Color.Peru;
            this.panAddnewRoom.BorderRadius = 15;
            this.panAddnewRoom.BorderSize = 2;
            this.panAddnewRoom.Controls.Add(this.btnAddnewRoom);
            this.panAddnewRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panAddnewRoom.ForeColor = System.Drawing.Color.Peru;
            this.panAddnewRoom.Location = new System.Drawing.Point(150, 0);
            this.panAddnewRoom.Name = "panAddnewRoom";
            this.panAddnewRoom.Size = new System.Drawing.Size(383, 419);
            this.panAddnewRoom.TabIndex = 10;
            // 
            // btnAddnewRoom
            // 
            this.btnAddnewRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAddnewRoom.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnAddnewRoom.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.btnAddnewRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddnewRoom.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddnewRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddnewRoom.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewRoom.ForeColor = System.Drawing.Color.Peru;
            this.btnAddnewRoom.Inactive1 = System.Drawing.Color.Transparent;
            this.btnAddnewRoom.Inactive2 = System.Drawing.Color.Transparent;
            this.btnAddnewRoom.Location = new System.Drawing.Point(0, 0);
            this.btnAddnewRoom.Name = "btnAddnewRoom";
            this.btnAddnewRoom.Radius = 15;
            this.btnAddnewRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddnewRoom.Size = new System.Drawing.Size(383, 419);
            this.btnAddnewRoom.Stroke = false;
            this.btnAddnewRoom.StrokeColor = System.Drawing.Color.Peru;
            this.btnAddnewRoom.TabIndex = 0;
            this.btnAddnewRoom.Text = "+";
            this.btnAddnewRoom.Transparency = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(852, 639);
            this.Controls.Add(this.panContaner);
            this.Controls.Add(this.splitter5);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.Text = "frmMain";
            this.panHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.panRoom.ResumeLayout(false);
            this.panRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            this.panContaner.ResumeLayout(false);
            this.panAddnewRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private WiLBiT.WiLBiTRoundedPictureBox2 picAppIcon;
        private AltoControls.AltoButton btnMinimize;
        private AltoControls.AltoButton btnExit;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter5;
        private WiLBiT.WiLBiTGradientPanel panRoom;
        private WiLBiT.WiLBiTButton btnOpenRoom;
        private WiLBiT.WiLBiTButton btnManageRoom;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Panel panContaner;
        private WiLBiT.WiLBiTGradientPanel panAddnewRoom;
        private AltoControls.AltoButton btnAddnewRoom;
    }
}