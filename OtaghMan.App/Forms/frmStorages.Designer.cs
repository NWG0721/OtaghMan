namespace OtaghMan.App.Forms
{
    partial class frmStorages
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
            this.panStorages = new System.Windows.Forms.Panel();
            this.panContaneStorage = new System.Windows.Forms.Panel();
            this.TopSplit = new System.Windows.Forms.Splitter();
            this.panTop = new System.Windows.Forms.Panel();
            this.txtSearch = new AltoControls.AltoTextBox();
            this.altoButton3 = new AltoControls.AltoButton();
            this.btnAddStorage = new AltoControls.AltoButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewEquip = new AltoControls.AltoButton();
            this.altoButton2 = new AltoControls.AltoButton();
            this.lblStorageName = new AltoControls.AltoSlidingLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoomName = new AltoControls.AltoSlidingLabel();
            this.lpcEquipments = new System.Windows.Forms.FlowLayoutPanel();
            btnHeader = new AltoControls.AltoButton();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            this.panStorages.SuspendLayout();
            this.panTop.SuspendLayout();
            this.panel1.SuspendLayout();
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
            btnHeader.Size = new System.Drawing.Size(1095, 37);
            btnHeader.Stroke = false;
            btnHeader.StrokeColor = System.Drawing.Color.Gray;
            btnHeader.TabIndex = 8;
            btnHeader.Text = "Otagh-e Man";
            btnHeader.Transparency = false;
            btnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // panHead
            // 
            this.panHead.Controls.Add(btnHeader);
            this.panHead.Controls.Add(this.picAppIcon);
            this.panHead.Controls.Add(this.btnMinimize);
            this.panHead.Controls.Add(this.btnExit);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(1200, 37);
            this.panHead.TabIndex = 0;
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
            this.picAppIcon.TabIndex = 5;
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
            this.btnMinimize.Location = new System.Drawing.Point(1130, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Radius = 10;
            this.btnMinimize.Size = new System.Drawing.Size(35, 37);
            this.btnMinimize.Stroke = false;
            this.btnMinimize.StrokeColor = System.Drawing.Color.Gray;
            this.btnMinimize.TabIndex = 7;
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
            this.btnExit.Location = new System.Drawing.Point(1165, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 10;
            this.btnExit.Size = new System.Drawing.Size(35, 37);
            this.btnExit.Stroke = false;
            this.btnExit.StrokeColor = System.Drawing.Color.Gray;
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "✕";
            this.btnExit.Transparency = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panStorages
            // 
            this.panStorages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panStorages.Controls.Add(this.panContaneStorage);
            this.panStorages.Controls.Add(this.TopSplit);
            this.panStorages.Controls.Add(this.panTop);
            this.panStorages.Dock = System.Windows.Forms.DockStyle.Left;
            this.panStorages.Location = new System.Drawing.Point(0, 37);
            this.panStorages.Name = "panStorages";
            this.panStorages.Size = new System.Drawing.Size(268, 634);
            this.panStorages.TabIndex = 1;
            // 
            // panContaneStorage
            // 
            this.panContaneStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContaneStorage.Location = new System.Drawing.Point(0, 139);
            this.panContaneStorage.Name = "panContaneStorage";
            this.panContaneStorage.Size = new System.Drawing.Size(268, 495);
            this.panContaneStorage.TabIndex = 4;
            // 
            // TopSplit
            // 
            this.TopSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSplit.Enabled = false;
            this.TopSplit.Location = new System.Drawing.Point(0, 129);
            this.TopSplit.Name = "TopSplit";
            this.TopSplit.Size = new System.Drawing.Size(268, 10);
            this.TopSplit.TabIndex = 3;
            this.TopSplit.TabStop = false;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.panTop.Controls.Add(this.txtSearch);
            this.panTop.Controls.Add(this.altoButton3);
            this.panTop.Controls.Add(this.btnAddStorage);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(268, 129);
            this.panTop.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.Br = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(6, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 56);
            this.txtSearch.TabIndex = 17;
            // 
            // altoButton3
            // 
            this.altoButton3.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.altoButton3.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.altoButton3.BackColor = System.Drawing.Color.Transparent;
            this.altoButton3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton3.ForeColor = System.Drawing.Color.Peru;
            this.altoButton3.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.altoButton3.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton3.Location = new System.Drawing.Point(135, 3);
            this.altoButton3.Name = "altoButton3";
            this.altoButton3.Radius = 10;
            this.altoButton3.Size = new System.Drawing.Size(127, 60);
            this.altoButton3.Stroke = true;
            this.altoButton3.StrokeColor = System.Drawing.Color.Peru;
            this.altoButton3.TabIndex = 16;
            this.altoButton3.Text = "تازه سازی";
            this.altoButton3.Transparency = false;
            this.altoButton3.Click += new System.EventHandler(this.altoButton3_Click);
            // 
            // btnAddStorage
            // 
            this.btnAddStorage.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnAddStorage.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnAddStorage.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStorage.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddStorage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStorage.ForeColor = System.Drawing.Color.Peru;
            this.btnAddStorage.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnAddStorage.Inactive2 = System.Drawing.Color.Transparent;
            this.btnAddStorage.Location = new System.Drawing.Point(5, 3);
            this.btnAddStorage.Name = "btnAddStorage";
            this.btnAddStorage.Radius = 10;
            this.btnAddStorage.Size = new System.Drawing.Size(127, 60);
            this.btnAddStorage.Stroke = true;
            this.btnAddStorage.StrokeColor = System.Drawing.Color.Peru;
            this.btnAddStorage.TabIndex = 14;
            this.btnAddStorage.Text = "افزودن جدید";
            this.btnAddStorage.Transparency = false;
            this.btnAddStorage.Click += new System.EventHandler(this.btnAddStorage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.btnAddNewEquip);
            this.panel1.Controls.Add(this.altoButton2);
            this.panel1.Controls.Add(this.lblStorageName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblRoomName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(268, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 67);
            this.panel1.TabIndex = 3;
            // 
            // btnAddNewEquip
            // 
            this.btnAddNewEquip.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnAddNewEquip.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnAddNewEquip.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewEquip.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewEquip.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewEquip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEquip.ForeColor = System.Drawing.Color.Peru;
            this.btnAddNewEquip.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnAddNewEquip.Inactive2 = System.Drawing.Color.Transparent;
            this.btnAddNewEquip.Location = new System.Drawing.Point(678, 0);
            this.btnAddNewEquip.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnAddNewEquip.Name = "btnAddNewEquip";
            this.btnAddNewEquip.Radius = 10;
            this.btnAddNewEquip.Size = new System.Drawing.Size(127, 67);
            this.btnAddNewEquip.Stroke = true;
            this.btnAddNewEquip.StrokeColor = System.Drawing.Color.Peru;
            this.btnAddNewEquip.TabIndex = 17;
            this.btnAddNewEquip.Text = "افزودن جدید";
            this.btnAddNewEquip.Transparency = false;
            this.btnAddNewEquip.Click += new System.EventHandler(this.btnAddNewEquip_Click);
            // 
            // altoButton2
            // 
            this.altoButton2.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.altoButton2.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.altoButton2.BackColor = System.Drawing.Color.Transparent;
            this.altoButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.altoButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton2.ForeColor = System.Drawing.Color.Peru;
            this.altoButton2.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.altoButton2.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton2.Location = new System.Drawing.Point(805, 0);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Radius = 10;
            this.altoButton2.Size = new System.Drawing.Size(127, 67);
            this.altoButton2.Stroke = true;
            this.altoButton2.StrokeColor = System.Drawing.Color.Peru;
            this.altoButton2.TabIndex = 18;
            this.altoButton2.Text = "تازه سازی";
            this.altoButton2.Transparency = false;
            this.altoButton2.Click += new System.EventHandler(this.altoButton2_Click);
            // 
            // lblStorageName
            // 
            this.lblStorageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageName.ForeColor = System.Drawing.Color.Peru;
            this.lblStorageName.Location = new System.Drawing.Point(116, 3);
            this.lblStorageName.Name = "lblStorageName";
            this.lblStorageName.Size = new System.Drawing.Size(77, 28);
            this.lblStorageName.Slide = false;
            this.lblStorageName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(86, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "<";
            // 
            // lblRoomName
            // 
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.ForeColor = System.Drawing.Color.Peru;
            this.lblRoomName.Location = new System.Drawing.Point(3, 3);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(77, 28);
            this.lblRoomName.Slide = false;
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "fgh";
            this.lblRoomName.Click += new System.EventHandler(this.lblRoomName_Click);
            // 
            // lpcEquipments
            // 
            this.lpcEquipments.AutoScroll = true;
            this.lpcEquipments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpcEquipments.Location = new System.Drawing.Point(268, 104);
            this.lpcEquipments.Name = "lpcEquipments";
            this.lpcEquipments.Size = new System.Drawing.Size(932, 567);
            this.lpcEquipments.TabIndex = 4;
            // 
            // frmStorages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1200, 671);
            this.Controls.Add(this.lpcEquipments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panStorages);
            this.Controls.Add(this.panHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStorages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStorages_Load);
            this.panHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            this.panStorages.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private WiLBiT.WiLBiTRoundedPictureBox2 picAppIcon;
        private AltoControls.AltoButton btnMinimize;
        private AltoControls.AltoButton btnExit;
        private System.Windows.Forms.Panel panStorages;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter TopSplit;
        private System.Windows.Forms.Panel panContaneStorage;
        private AltoControls.AltoSlidingLabel lblStorageName;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoSlidingLabel lblRoomName;
        private AltoControls.AltoButton btnAddStorage;
        private AltoControls.AltoTextBox txtSearch;
        private AltoControls.AltoButton altoButton3;
        private AltoControls.AltoButton altoButton2;
        private AltoControls.AltoButton btnAddNewEquip;
        private System.Windows.Forms.FlowLayoutPanel lpcEquipments;
    }
}