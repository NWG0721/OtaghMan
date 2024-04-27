namespace OtaghMan.App
{
    partial class Sgining
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
            this.splitRight = new System.Windows.Forms.Splitter();
            this.splitLeft = new System.Windows.Forms.Splitter();
            this.txtUserName = new WiLBiT.WiLBiTTextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassWord = new WiLBiT.WiLBiTTextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtRePass = new WiLBiT.WiLBiTTextBox();
            this.lblRePass = new System.Windows.Forms.Label();
            this.lblRepassBad = new System.Windows.Forms.Label();
            this.picStatePassWord = new System.Windows.Forms.PictureBox();
            this.btnEnter = new AltoControls.AltoButton();
            this.btnSignInOrSignUp = new AltoControls.AltoButton();
            this.lblBadUserPass = new System.Windows.Forms.Label();
            this.panSigning = new WiLBiT.WiLBiTGradientPanel();
            btnHeader = new AltoControls.AltoButton();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiLBiTRoundedPictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatePassWord)).BeginInit();
            this.panSigning.SuspendLayout();
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
            this.panHead.Size = new System.Drawing.Size(900, 35);
            this.panHead.TabIndex = 0;
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
            btnHeader.Size = new System.Drawing.Size(795, 35);
            btnHeader.Stroke = false;
            btnHeader.StrokeColor = System.Drawing.Color.Gray;
            btnHeader.TabIndex = 4;
            btnHeader.Text = "Otagh-e Man";
            btnHeader.Transparency = false;
            btnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
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
            this.btnMinimize.Location = new System.Drawing.Point(830, 0);
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
            this.btnExit.Location = new System.Drawing.Point(865, 0);
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
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitRight.Enabled = false;
            this.splitRight.Location = new System.Drawing.Point(680, 35);
            this.splitRight.Name = "splitRight";
            this.splitRight.Size = new System.Drawing.Size(220, 565);
            this.splitRight.TabIndex = 2;
            this.splitRight.TabStop = false;
            // 
            // splitLeft
            // 
            this.splitLeft.Enabled = false;
            this.splitLeft.Location = new System.Drawing.Point(0, 35);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Size = new System.Drawing.Size(220, 565);
            this.splitLeft.TabIndex = 3;
            this.splitLeft.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderRadius = 15;
            this.txtUserName.BorderSize = 3;
            this.txtUserName.Font = new System.Drawing.Font("Mj_Beirut", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(78, 75);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "اسمت";
            this.txtUserName.Size = new System.Drawing.Size(250, 47);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            this.txtUserName._TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Mj_Beirut", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Location = new System.Drawing.Point(335, 75);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(128, 41);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "نام کاربری:";
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.txtPassWord.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPassWord.BorderRadius = 15;
            this.txtPassWord.BorderSize = 3;
            this.txtPassWord.Font = new System.Drawing.Font("Mj_Beirut", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassWord.Location = new System.Drawing.Point(78, 196);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.Multiline = false;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassWord.PasswordChar = true;
            this.txtPassWord.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassWord.PlaceholderText = "پسوردت";
            this.txtPassWord.Size = new System.Drawing.Size(250, 47);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.Texts = "";
            this.txtPassWord.UnderlinedStyle = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Mj_Beirut", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPass.ForeColor = System.Drawing.Color.Blue;
            this.lblPass.Location = new System.Drawing.Point(344, 202);
            this.lblPass.Name = "lblPass";
            this.lblPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPass.Size = new System.Drawing.Size(120, 41);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "رمز ورود:";
            // 
            // txtRePass
            // 
            this.txtRePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRePass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.txtRePass.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtRePass.BorderRadius = 15;
            this.txtRePass.BorderSize = 3;
            this.txtRePass.Font = new System.Drawing.Font("Mj_Beirut", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRePass.Location = new System.Drawing.Point(78, 324);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRePass.Multiline = false;
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRePass.PasswordChar = true;
            this.txtRePass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRePass.PlaceholderText = "دوباره پسوردت";
            this.txtRePass.Size = new System.Drawing.Size(250, 47);
            this.txtRePass.TabIndex = 5;
            this.txtRePass.Texts = "";
            this.txtRePass.UnderlinedStyle = false;
            this.txtRePass.Visible = false;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.BackColor = System.Drawing.Color.Transparent;
            this.lblRePass.Font = new System.Drawing.Font("Mj_Beirut", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRePass.ForeColor = System.Drawing.Color.Blue;
            this.lblRePass.Location = new System.Drawing.Point(346, 330);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRePass.Size = new System.Drawing.Size(110, 41);
            this.lblRePass.TabIndex = 6;
            this.lblRePass.Text = "بازم رمز:";
            this.lblRePass.Visible = false;
            // 
            // lblRepassBad
            // 
            this.lblRepassBad.AutoSize = true;
            this.lblRepassBad.BackColor = System.Drawing.Color.Transparent;
            this.lblRepassBad.Font = new System.Drawing.Font("Mj_Beirut", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRepassBad.ForeColor = System.Drawing.Color.Red;
            this.lblRepassBad.Location = new System.Drawing.Point(246, 375);
            this.lblRepassBad.Name = "lblRepassBad";
            this.lblRepassBad.Size = new System.Drawing.Size(98, 28);
            this.lblRepassBad.TabIndex = 8;
            this.lblRepassBad.Text = "رمزا یکی نیست";
            this.lblRepassBad.Visible = false;
            // 
            // picStatePassWord
            // 
            this.picStatePassWord.BackColor = System.Drawing.Color.Transparent;
            this.picStatePassWord.Image = global::OtaghMan.App.Properties.Resources.icons8_view_48;
            this.picStatePassWord.Location = new System.Drawing.Point(35, 241);
            this.picStatePassWord.Name = "picStatePassWord";
            this.picStatePassWord.Size = new System.Drawing.Size(45, 50);
            this.picStatePassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatePassWord.TabIndex = 9;
            this.picStatePassWord.TabStop = false;
            this.picStatePassWord.Click += new System.EventHandler(this.picStatePassWord_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEnter.Active2 = System.Drawing.Color.Lime;
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnter.Font = new System.Drawing.Font("Mj_Beirut", 14.25F);
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Inactive1 = System.Drawing.Color.Transparent;
            this.btnEnter.Inactive2 = System.Drawing.Color.Transparent;
            this.btnEnter.Location = new System.Drawing.Point(225, 482);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Radius = 20;
            this.btnEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEnter.Size = new System.Drawing.Size(193, 59);
            this.btnEnter.Stroke = true;
            this.btnEnter.StrokeColor = System.Drawing.Color.Lime;
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "ورود کردن";
            this.btnEnter.Transparency = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnSignInOrSignUp
            // 
            this.btnSignInOrSignUp.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSignInOrSignUp.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignInOrSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignInOrSignUp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSignInOrSignUp.Font = new System.Drawing.Font("Mj_Beirut", 14.25F);
            this.btnSignInOrSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignInOrSignUp.Inactive1 = System.Drawing.Color.Transparent;
            this.btnSignInOrSignUp.Inactive2 = System.Drawing.Color.Transparent;
            this.btnSignInOrSignUp.Location = new System.Drawing.Point(26, 482);
            this.btnSignInOrSignUp.Name = "btnSignInOrSignUp";
            this.btnSignInOrSignUp.Radius = 20;
            this.btnSignInOrSignUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSignInOrSignUp.Size = new System.Drawing.Size(193, 59);
            this.btnSignInOrSignUp.Stroke = true;
            this.btnSignInOrSignUp.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignInOrSignUp.TabIndex = 10;
            this.btnSignInOrSignUp.Text = "ثبت نام";
            this.btnSignInOrSignUp.Transparency = false;
            this.btnSignInOrSignUp.Click += new System.EventHandler(this.btnSignInOrSignUp_Click);
            // 
            // lblBadUserPass
            // 
            this.lblBadUserPass.AutoSize = true;
            this.lblBadUserPass.BackColor = System.Drawing.Color.Transparent;
            this.lblBadUserPass.Font = new System.Drawing.Font("Mj_Beirut", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBadUserPass.ForeColor = System.Drawing.Color.Red;
            this.lblBadUserPass.Location = new System.Drawing.Point(51, 438);
            this.lblBadUserPass.Name = "lblBadUserPass";
            this.lblBadUserPass.Size = new System.Drawing.Size(347, 41);
            this.lblBadUserPass.TabIndex = 11;
            this.lblBadUserPass.Text = "نام کاربری یا رمز عبور یکی نیستن گلم";
            this.lblBadUserPass.Visible = false;
            // 
            // panSigning
            // 
            this.panSigning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panSigning.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.panSigning.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.panSigning.BorderRadius = 30;
            this.panSigning.BorderSize = 5;
            this.panSigning.Controls.Add(this.lblBadUserPass);
            this.panSigning.Controls.Add(this.btnSignInOrSignUp);
            this.panSigning.Controls.Add(this.btnEnter);
            this.panSigning.Controls.Add(this.picStatePassWord);
            this.panSigning.Controls.Add(this.lblRepassBad);
            this.panSigning.Controls.Add(this.lblRePass);
            this.panSigning.Controls.Add(this.txtRePass);
            this.panSigning.Controls.Add(this.lblPass);
            this.panSigning.Controls.Add(this.txtPassWord);
            this.panSigning.Controls.Add(this.lblUserName);
            this.panSigning.Controls.Add(this.txtUserName);
            this.panSigning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSigning.ForeColor = System.Drawing.Color.White;
            this.panSigning.Location = new System.Drawing.Point(220, 35);
            this.panSigning.Name = "panSigning";
            this.panSigning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panSigning.Size = new System.Drawing.Size(460, 565);
            this.panSigning.TabIndex = 1;
            // 
            // Sgining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panSigning);
            this.Controls.Add(this.splitLeft);
            this.Controls.Add(this.splitRight);
            this.Controls.Add(this.panHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sgining";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sgining_Load);
            this.panHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wiLBiTRoundedPictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatePassWord)).EndInit();
            this.panSigning.ResumeLayout(false);
            this.panSigning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private AltoControls.AltoButton btnExit;
        private AltoControls.AltoButton btnMinimize;
        private WiLBiT.WiLBiTRoundedPictureBox2 wiLBiTRoundedPictureBox21;
        private System.Windows.Forms.Splitter splitRight;
        private System.Windows.Forms.Splitter splitLeft;
        private WiLBiT.WiLBiTTextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private WiLBiT.WiLBiTTextBox txtPassWord;
        private System.Windows.Forms.Label lblPass;
        private WiLBiT.WiLBiTTextBox txtRePass;
        private System.Windows.Forms.Label lblRePass;
        private System.Windows.Forms.Label lblRepassBad;
        private System.Windows.Forms.PictureBox picStatePassWord;
        private AltoControls.AltoButton btnEnter;
        private AltoControls.AltoButton btnSignInOrSignUp;
        private System.Windows.Forms.Label lblBadUserPass;
        private WiLBiT.WiLBiTGradientPanel panSigning;
    }
}

