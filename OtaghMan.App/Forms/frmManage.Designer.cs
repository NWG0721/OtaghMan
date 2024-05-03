namespace OtaghMan.App
{
    partial class frmManage
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
            this.panPicBox = new WiLBiT.WiLBiTPanel();
            this.picRoomPicture = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new AltoControls.AltoButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRoomName = new AltoControls.AltoTextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.panDown = new System.Windows.Forms.Panel();
            this.btnClose = new AltoControls.AltoButton();
            this.btnOK = new AltoControls.AltoButton();
            this.btnDeleteRoom = new AltoControls.AltoButton();
            this.panPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPicBox
            // 
            this.panPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panPicBox.BorderColor = System.Drawing.Color.Peru;
            this.panPicBox.BorderRadius = 20;
            this.panPicBox.BorderSize = 0;
            this.panPicBox.Controls.Add(this.picRoomPicture);
            this.panPicBox.Controls.Add(this.btnAddPicture);
            this.panPicBox.Controls.Add(this.panel1);
            this.panPicBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panPicBox.Location = new System.Drawing.Point(12, 12);
            this.panPicBox.Name = "panPicBox";
            this.panPicBox.Size = new System.Drawing.Size(396, 340);
            this.panPicBox.TabIndex = 3;
            // 
            // picRoomPicture
            // 
            this.picRoomPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoomPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRoomPicture.Location = new System.Drawing.Point(0, 57);
            this.picRoomPicture.Name = "picRoomPicture";
            this.picRoomPicture.Size = new System.Drawing.Size(396, 239);
            this.picRoomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoomPicture.TabIndex = 4;
            this.picRoomPicture.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnAddPicture.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnAddPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPicture.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddPicture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddPicture.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.ForeColor = System.Drawing.Color.Peru;
            this.btnAddPicture.Inactive1 = System.Drawing.Color.Transparent;
            this.btnAddPicture.Inactive2 = System.Drawing.Color.Transparent;
            this.btnAddPicture.Location = new System.Drawing.Point(0, 296);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Radius = 20;
            this.btnAddPicture.Size = new System.Drawing.Size(396, 44);
            this.btnAddPicture.Stroke = true;
            this.btnAddPicture.StrokeColor = System.Drawing.Color.Peru;
            this.btnAddPicture.TabIndex = 3;
            this.btnAddPicture.Text = "انتخاب تصویر";
            this.btnAddPicture.Transparency = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRoomName);
            this.panel1.Controls.Add(this.lblRoomName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 57);
            this.panel1.TabIndex = 0;
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomName.Br = System.Drawing.Color.White;
            this.txtRoomName.Font = new System.Drawing.Font("B Yekan", 14.25F);
            this.txtRoomName.ForeColor = System.Drawing.Color.Black;
            this.txtRoomName.Location = new System.Drawing.Point(76, 18);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(135, 33);
            this.txtRoomName.TabIndex = 2;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRoomName.ForeColor = System.Drawing.Color.Peru;
            this.lblRoomName.Location = new System.Drawing.Point(228, 18);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(73, 29);
            this.lblRoomName.TabIndex = 1;
            this.lblRoomName.Text = "اسم اتاق";
            // 
            // panDown
            // 
            this.panDown.Controls.Add(this.btnClose);
            this.panDown.Controls.Add(this.btnOK);
            this.panDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDown.Location = new System.Drawing.Point(0, 414);
            this.panDown.Name = "panDown";
            this.panDown.Size = new System.Drawing.Size(420, 56);
            this.panDown.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnClose.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Peru;
            this.btnClose.Inactive1 = System.Drawing.Color.Transparent;
            this.btnClose.Inactive2 = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(169, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 20;
            this.btnClose.Size = new System.Drawing.Size(251, 56);
            this.btnClose.Stroke = true;
            this.btnClose.StrokeColor = System.Drawing.Color.Peru;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "بنداز بره";
            this.btnClose.Transparency = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnOK.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOK.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Peru;
            this.btnOK.Inactive1 = System.Drawing.Color.Transparent;
            this.btnOK.Inactive2 = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(0, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 20;
            this.btnOK.Size = new System.Drawing.Size(169, 56);
            this.btnOK.Stroke = true;
            this.btnOK.StrokeColor = System.Drawing.Color.Peru;
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "حله";
            this.btnOK.Transparency = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Active1 = System.Drawing.Color.Red;
            this.btnDeleteRoom.Active2 = System.Drawing.Color.DarkRed;
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRoom.Inactive1 = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.Inactive2 = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.Location = new System.Drawing.Point(12, 371);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Radius = 20;
            this.btnDeleteRoom.Size = new System.Drawing.Size(132, 37);
            this.btnDeleteRoom.Stroke = true;
            this.btnDeleteRoom.StrokeColor = System.Drawing.Color.Peru;
            this.btnDeleteRoom.TabIndex = 6;
            this.btnDeleteRoom.Text = "پاکیدن";
            this.btnDeleteRoom.Transparency = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.panPicBox);
            this.Controls.Add(this.panDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManage";
            this.Text = "frmManage";
            this.Load += new System.EventHandler(this.frmManage_Load);
            this.panPicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRoomPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel panPicBox;
        private System.Windows.Forms.PictureBox picRoomPicture;
        private AltoControls.AltoButton btnAddPicture;
        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoTextBox txtRoomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Panel panDown;
        private AltoControls.AltoButton btnClose;
        private AltoControls.AltoButton btnOK;
        private AltoControls.AltoButton btnDeleteRoom;
    }
}