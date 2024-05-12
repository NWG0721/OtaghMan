namespace OtaghMan.App.Forms
{
    partial class frmAddEquip
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
            this.btnAddPic = new AltoControls.AltoButton();
            this.picEquip = new System.Windows.Forms.PictureBox();
            this.lblEquipName = new System.Windows.Forms.Label();
            this.txtEquipName = new AltoControls.AltoTextBox();
            this.comboStorageName = new WiLBiT.WiLBiTComboBox();
            this.lblStorageName = new System.Windows.Forms.Label();
            this.comboEquipOwner = new WiLBiT.WiLBiTComboBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.btnOK = new AltoControls.AltoButton();
            this.btnCancel = new AltoControls.AltoButton();
            ((System.ComponentModel.ISupportInitialize)(this.picEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPic
            // 
            this.btnAddPic.Active1 = System.Drawing.Color.Aqua;
            this.btnAddPic.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddPic.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPic.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddPic.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPic.ForeColor = System.Drawing.Color.Black;
            this.btnAddPic.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnAddPic.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnAddPic.Location = new System.Drawing.Point(12, 234);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Radius = 10;
            this.btnAddPic.Size = new System.Drawing.Size(219, 30);
            this.btnAddPic.Stroke = false;
            this.btnAddPic.StrokeColor = System.Drawing.Color.Gray;
            this.btnAddPic.TabIndex = 1;
            this.btnAddPic.Text = "اضافه کردن تصویر";
            this.btnAddPic.Transparency = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // picEquip
            // 
            this.picEquip.Location = new System.Drawing.Point(12, 12);
            this.picEquip.Name = "picEquip";
            this.picEquip.Size = new System.Drawing.Size(219, 216);
            this.picEquip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEquip.TabIndex = 0;
            this.picEquip.TabStop = false;
            // 
            // lblEquipName
            // 
            this.lblEquipName.AutoSize = true;
            this.lblEquipName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblEquipName.Location = new System.Drawing.Point(456, 35);
            this.lblEquipName.Name = "lblEquipName";
            this.lblEquipName.Size = new System.Drawing.Size(53, 19);
            this.lblEquipName.TabIndex = 2;
            this.lblEquipName.Text = "نام کالا:";
            // 
            // txtEquipName
            // 
            this.txtEquipName.BackColor = System.Drawing.Color.Transparent;
            this.txtEquipName.Br = System.Drawing.Color.White;
            this.txtEquipName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.txtEquipName.ForeColor = System.Drawing.Color.DimGray;
            this.txtEquipName.Location = new System.Drawing.Point(272, 30);
            this.txtEquipName.Name = "txtEquipName";
            this.txtEquipName.Size = new System.Drawing.Size(178, 28);
            this.txtEquipName.TabIndex = 3;
            // 
            // comboStorageName
            // 
            this.comboStorageName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboStorageName.BorderColor = System.Drawing.Color.Peru;
            this.comboStorageName.BorderSize = 2;
            this.comboStorageName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboStorageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboStorageName.ForeColor = System.Drawing.Color.DimGray;
            this.comboStorageName.IconColor = System.Drawing.Color.Peru;
            this.comboStorageName.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboStorageName.ListTextColor = System.Drawing.Color.DimGray;
            this.comboStorageName.Location = new System.Drawing.Point(272, 120);
            this.comboStorageName.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboStorageName.Name = "comboStorageName";
            this.comboStorageName.Padding = new System.Windows.Forms.Padding(2);
            this.comboStorageName.Size = new System.Drawing.Size(233, 30);
            this.comboStorageName.TabIndex = 4;
            this.comboStorageName.Texts = "";
            // 
            // lblStorageName
            // 
            this.lblStorageName.AutoSize = true;
            this.lblStorageName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblStorageName.Location = new System.Drawing.Point(347, 98);
            this.lblStorageName.Name = "lblStorageName";
            this.lblStorageName.Size = new System.Drawing.Size(82, 19);
            this.lblStorageName.TabIndex = 5;
            this.lblStorageName.Text = "محل نگهداری";
            // 
            // comboEquipOwner
            // 
            this.comboEquipOwner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboEquipOwner.BorderColor = System.Drawing.Color.Peru;
            this.comboEquipOwner.BorderSize = 2;
            this.comboEquipOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboEquipOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboEquipOwner.ForeColor = System.Drawing.Color.DimGray;
            this.comboEquipOwner.IconColor = System.Drawing.Color.Peru;
            this.comboEquipOwner.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboEquipOwner.ListTextColor = System.Drawing.Color.DimGray;
            this.comboEquipOwner.Location = new System.Drawing.Point(272, 198);
            this.comboEquipOwner.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboEquipOwner.Name = "comboEquipOwner";
            this.comboEquipOwner.Padding = new System.Windows.Forms.Padding(2);
            this.comboEquipOwner.Size = new System.Drawing.Size(233, 30);
            this.comboEquipOwner.TabIndex = 4;
            this.comboEquipOwner.Texts = "";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblOwner.Location = new System.Drawing.Point(372, 176);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(32, 19);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "مالک";
            // 
            // btnOK
            // 
            this.btnOK.Active1 = System.Drawing.Color.Lime;
            this.btnOK.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Inactive1 = System.Drawing.Color.Lime;
            this.btnOK.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.Location = new System.Drawing.Point(12, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 10;
            this.btnOK.Size = new System.Drawing.Size(245, 44);
            this.btnOK.Stroke = false;
            this.btnOK.StrokeColor = System.Drawing.Color.Gray;
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "اضافه کردن";
            this.btnOK.Transparency = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Inactive2 = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(272, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(245, 44);
            this.btnCancel.Stroke = false;
            this.btnCancel.StrokeColor = System.Drawing.Color.Gray;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "بندار بره";
            this.btnCancel.Transparency = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblStorageName);
            this.Controls.Add(this.comboEquipOwner);
            this.Controls.Add(this.comboStorageName);
            this.Controls.Add(this.txtEquipName);
            this.Controls.Add(this.lblEquipName);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.picEquip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEquip";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmAddEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEquip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEquip;
        private AltoControls.AltoButton btnAddPic;
        private System.Windows.Forms.Label lblEquipName;
        private AltoControls.AltoTextBox txtEquipName;
        private WiLBiT.WiLBiTComboBox comboStorageName;
        private System.Windows.Forms.Label lblStorageName;
        private WiLBiT.WiLBiTComboBox comboEquipOwner;
        private System.Windows.Forms.Label lblOwner;
        private AltoControls.AltoButton btnOK;
        private AltoControls.AltoButton btnCancel;
    }
}