namespace OtaghMan.App
{
    partial class frmClickRightForStorageAndEquip
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.altoButton1 = new AltoControls.AltoButton();
            this.btnDelete = new AltoControls.AltoButton();
            this.btnClose = new AltoControls.AltoButton();
            this.txtStorageOrEquipmentName = new AltoControls.AltoTextBox();
            this.lblObjName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.altoButton1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 76);
            this.panel1.TabIndex = 0;
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altoButton1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton1.ForeColor = System.Drawing.Color.Black;
            this.altoButton1.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton1.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton1.Location = new System.Drawing.Point(79, 0);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 20;
            this.altoButton1.Size = new System.Drawing.Size(186, 76);
            this.altoButton1.Stroke = true;
            this.altoButton1.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.altoButton1.TabIndex = 4;
            this.altoButton1.Text = "ویرایش";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Active1 = System.Drawing.Color.Red;
            this.btnDelete.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Inactive1 = System.Drawing.Color.Transparent;
            this.btnDelete.Inactive2 = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(79, 76);
            this.btnDelete.Stroke = true;
            this.btnDelete.StrokeColor = System.Drawing.Color.Red;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "پاکیدن";
            this.btnDelete.Transparency = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Active1 = System.Drawing.Color.Red;
            this.btnClose.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Inactive1 = System.Drawing.Color.Transparent;
            this.btnClose.Inactive2 = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(197, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(68, 28);
            this.btnClose.Stroke = true;
            this.btnClose.StrokeColor = System.Drawing.Color.Red;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "بستن";
            this.btnClose.Transparency = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtStorageOrEquipmentName
            // 
            this.txtStorageOrEquipmentName.BackColor = System.Drawing.Color.Transparent;
            this.txtStorageOrEquipmentName.Br = System.Drawing.Color.White;
            this.txtStorageOrEquipmentName.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtStorageOrEquipmentName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStorageOrEquipmentName.Location = new System.Drawing.Point(28, 44);
            this.txtStorageOrEquipmentName.Name = "txtStorageOrEquipmentName";
            this.txtStorageOrEquipmentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStorageOrEquipmentName.Size = new System.Drawing.Size(151, 43);
            this.txtStorageOrEquipmentName.TabIndex = 5;
            // 
            // lblObjName
            // 
            this.lblObjName.AutoSize = true;
            this.lblObjName.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lblObjName.Location = new System.Drawing.Point(193, 55);
            this.lblObjName.Name = "lblObjName";
            this.lblObjName.Size = new System.Drawing.Size(22, 20);
            this.lblObjName.TabIndex = 6;
            this.lblObjName.Text = "نام";
            // 
            // frmClickRightForStorageAndEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 185);
            this.Controls.Add(this.lblObjName);
            this.Controls.Add(this.txtStorageOrEquipmentName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClickRightForStorageAndEquip";
            this.Load += new System.EventHandler(this.frmClickRightForStorageAndEquip_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoButton altoButton1;
        private AltoControls.AltoButton btnDelete;
        private AltoControls.AltoButton btnClose;
        private AltoControls.AltoTextBox txtStorageOrEquipmentName;
        private System.Windows.Forms.Label lblObjName;
    }
}