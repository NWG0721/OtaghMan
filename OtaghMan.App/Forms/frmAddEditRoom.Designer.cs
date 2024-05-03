namespace OtaghMan.App
{
    partial class frmAddEditRoom
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
            this.txtRoomName = new AltoControls.AltoTextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.panDown = new System.Windows.Forms.Panel();
            this.altoButton3 = new AltoControls.AltoButton();
            this.altoButton1 = new AltoControls.AltoButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPicture = new AltoControls.AltoButton();
            this.picRoomPicture = new System.Windows.Forms.PictureBox();
            this.panPicBox = new WiLBiT.WiLBiTPanel();
            this.panDown.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomPicture)).BeginInit();
            this.panPicBox.SuspendLayout();
            this.SuspendLayout();
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
            this.panDown.Controls.Add(this.altoButton3);
            this.panDown.Controls.Add(this.altoButton1);
            this.panDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDown.Location = new System.Drawing.Point(0, 394);
            this.panDown.Name = "panDown";
            this.panDown.Size = new System.Drawing.Size(340, 56);
            this.panDown.TabIndex = 2;
            // 
            // altoButton3
            // 
            this.altoButton3.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.altoButton3.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.altoButton3.BackColor = System.Drawing.Color.Transparent;
            this.altoButton3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altoButton3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton3.ForeColor = System.Drawing.Color.Peru;
            this.altoButton3.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton3.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton3.Location = new System.Drawing.Point(169, 0);
            this.altoButton3.Name = "altoButton3";
            this.altoButton3.Radius = 20;
            this.altoButton3.Size = new System.Drawing.Size(171, 56);
            this.altoButton3.Stroke = true;
            this.altoButton3.StrokeColor = System.Drawing.Color.Peru;
            this.altoButton3.TabIndex = 4;
            this.altoButton3.Text = "بنداز بره";
            this.altoButton3.Transparency = false;
            this.altoButton3.Click += new System.EventHandler(this.altoButton3_Click);
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.altoButton1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton1.ForeColor = System.Drawing.Color.Peru;
            this.altoButton1.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton1.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton1.Location = new System.Drawing.Point(0, 0);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 20;
            this.altoButton1.Size = new System.Drawing.Size(169, 56);
            this.altoButton1.Stroke = true;
            this.altoButton1.StrokeColor = System.Drawing.Color.Peru;
            this.altoButton1.TabIndex = 5;
            this.altoButton1.Text = "حله";
            this.altoButton1.Transparency = true;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRoomName);
            this.panel1.Controls.Add(this.lblRoomName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 57);
            this.panel1.TabIndex = 0;
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
            this.btnAddPicture.Size = new System.Drawing.Size(316, 44);
            this.btnAddPicture.Stroke = true;
            this.btnAddPicture.StrokeColor = System.Drawing.Color.Peru;
            this.btnAddPicture.TabIndex = 3;
            this.btnAddPicture.Text = "انتخاب تصویر";
            this.btnAddPicture.Transparency = false;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // picRoomPicture
            // 
            this.picRoomPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoomPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRoomPicture.Location = new System.Drawing.Point(0, 57);
            this.picRoomPicture.Name = "picRoomPicture";
            this.picRoomPicture.Size = new System.Drawing.Size(316, 239);
            this.picRoomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoomPicture.TabIndex = 4;
            this.picRoomPicture.TabStop = false;
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
            this.panPicBox.Size = new System.Drawing.Size(316, 340);
            this.panPicBox.TabIndex = 1;
            // 
            // frmAddEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.panDown);
            this.Controls.Add(this.panPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddEditRoom_Load);
            this.panDown.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomPicture)).EndInit();
            this.panPicBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Panel panDown;
        private AltoControls.AltoButton altoButton3;
        private AltoControls.AltoButton altoButton1;
        private AltoControls.AltoTextBox txtRoomName;
        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoButton btnAddPicture;
        private System.Windows.Forms.PictureBox picRoomPicture;
        private WiLBiT.WiLBiTPanel panPicBox;
    }
}