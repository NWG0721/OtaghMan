namespace OtaghMan.App
{
    partial class frmAddStorage
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
            this.txtAddStorage = new AltoControls.AltoButton();
            this.panDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomName.Br = System.Drawing.Color.White;
            this.txtRoomName.Font = new System.Drawing.Font("B Yekan", 14.25F);
            this.txtRoomName.ForeColor = System.Drawing.Color.Black;
            this.txtRoomName.Location = new System.Drawing.Point(12, 20);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(237, 33);
            this.txtRoomName.TabIndex = 2;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRoomName.ForeColor = System.Drawing.Color.Peru;
            this.lblRoomName.Location = new System.Drawing.Point(255, 20);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(123, 29);
            this.lblRoomName.TabIndex = 1;
            this.lblRoomName.Text = "اسم محل ذخیره";
            // 
            // panDown
            // 
            this.panDown.Controls.Add(this.altoButton3);
            this.panDown.Controls.Add(this.txtAddStorage);
            this.panDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDown.Location = new System.Drawing.Point(0, 71);
            this.panDown.Name = "panDown";
            this.panDown.Size = new System.Drawing.Size(390, 56);
            this.panDown.TabIndex = 4;
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
            this.altoButton3.Size = new System.Drawing.Size(221, 56);
            this.altoButton3.Stroke = true;
            this.altoButton3.StrokeColor = System.Drawing.Color.Peru;
            this.altoButton3.TabIndex = 4;
            this.altoButton3.Text = "بنداز بره";
            this.altoButton3.Transparency = false;
            this.altoButton3.Click += new System.EventHandler(this.altoButton3_Click);
            // 
            // txtAddStorage
            // 
            this.txtAddStorage.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.txtAddStorage.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.txtAddStorage.BackColor = System.Drawing.Color.Transparent;
            this.txtAddStorage.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.txtAddStorage.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAddStorage.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStorage.ForeColor = System.Drawing.Color.Peru;
            this.txtAddStorage.Inactive1 = System.Drawing.Color.Transparent;
            this.txtAddStorage.Inactive2 = System.Drawing.Color.Transparent;
            this.txtAddStorage.Location = new System.Drawing.Point(0, 0);
            this.txtAddStorage.Name = "txtAddStorage";
            this.txtAddStorage.Radius = 20;
            this.txtAddStorage.Size = new System.Drawing.Size(169, 56);
            this.txtAddStorage.Stroke = true;
            this.txtAddStorage.StrokeColor = System.Drawing.Color.Peru;
            this.txtAddStorage.TabIndex = 5;
            this.txtAddStorage.Text = "حله";
            this.txtAddStorage.Transparency = true;
            this.txtAddStorage.Click += new System.EventHandler(this.txtAddStorage_Click);
            // 
            // frmAddStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(390, 127);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.panDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddStorage";
            this.panDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AltoControls.AltoTextBox txtRoomName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Panel panDown;
        private AltoControls.AltoButton altoButton3;
        private AltoControls.AltoButton txtAddStorage;
    }
}