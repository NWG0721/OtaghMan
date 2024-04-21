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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sgining));
            this.panHead = new System.Windows.Forms.Panel();
            this.picAppIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.altoButton1 = new AltoControls.AltoButton();
            this.btnMinimize = new AltoControls.AltoButton();
            this.btnExit = new AltoControls.AltoButton();
            this.transTextBox = new Guna.UI2.WinForms.Guna2Transition();
            this.panRight = new System.Windows.Forms.Panel();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.picStatePassWord = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.btnSigning = new AltoControls.AltoButton();
            this.btnChanger = new AltoControls.AltoButton();
            this.txtRePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRePass = new System.Windows.Forms.Label();
            this.pangradLOG = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatePassWord)).BeginInit();
            this.pangradLOG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.Transparent;
            this.panHead.Controls.Add(this.picAppIcon);
            this.panHead.Controls.Add(this.altoButton1);
            this.panHead.Controls.Add(this.btnMinimize);
            this.panHead.Controls.Add(this.btnExit);
            this.transTextBox.SetDecoration(this.panHead, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(900, 35);
            this.panHead.TabIndex = 0;
            // 
            // picAppIcon
            // 
            this.transTextBox.SetDecoration(this.picAppIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picAppIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAppIcon.Image = global::OtaghMan.App.Properties.Resources.Untitled_1;
            this.picAppIcon.ImageRotate = 0F;
            this.picAppIcon.InitialImage = global::OtaghMan.App.Properties.Resources.Untitled_1;
            this.picAppIcon.Location = new System.Drawing.Point(0, 0);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAppIcon.Size = new System.Drawing.Size(37, 35);
            this.picAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppIcon.TabIndex = 1;
            this.picAppIcon.TabStop = false;
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.Transparent;
            this.altoButton1.Active2 = System.Drawing.Color.Transparent;
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.altoButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altoButton1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton1.ForeColor = System.Drawing.Color.Cyan;
            this.altoButton1.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton1.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton1.Location = new System.Drawing.Point(0, 0);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(830, 35);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 3;
            this.altoButton1.Text = "Otagh-e Man";
            this.altoButton1.Transparency = false;
            this.altoButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnMinimize.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.transTextBox.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // transTextBox
            // 
            this.transTextBox.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transTextBox.DefaultAnimation = animation1;
            // 
            // panRight
            // 
            this.panRight.BackColor = System.Drawing.Color.Transparent;
            this.panRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transTextBox.SetDecoration(this.panRight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRight.Location = new System.Drawing.Point(420, 35);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(480, 565);
            this.panRight.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Animated = true;
            this.txtUserName.AutoRoundedCorners = true;
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BorderRadius = 26;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transTextBox.SetDecoration(this.txtUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.Silver;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("NPINazaninTitr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(16, 143);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(252, 54);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassWord.Animated = true;
            this.txtPassWord.AutoRoundedCorners = true;
            this.txtPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord.BorderRadius = 26;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transTextBox.SetDecoration(this.txtPassWord, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassWord.DefaultText = "";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FillColor = System.Drawing.Color.Silver;
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Font = new System.Drawing.Font("NPINazaninTitr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.Color.Black;
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Location = new System.Drawing.Point(16, 263);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '●';
            this.txtPassWord.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtPassWord.PlaceholderText = "";
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(252, 54);
            this.txtPassWord.TabIndex = 5;
            // 
            // picStatePassWord
            // 
            this.picStatePassWord.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.picStatePassWord, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picStatePassWord.FillColor = System.Drawing.Color.Transparent;
            this.picStatePassWord.Image = global::OtaghMan.App.Properties.Resources.icons8_view_48;
            this.picStatePassWord.ImageRotate = 0F;
            this.picStatePassWord.InitialImage = global::OtaghMan.App.Properties.Resources.icons8_view_48;
            this.picStatePassWord.Location = new System.Drawing.Point(284, 267);
            this.picStatePassWord.Name = "picStatePassWord";
            this.picStatePassWord.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picStatePassWord.Size = new System.Drawing.Size(50, 46);
            this.picStatePassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatePassWord.TabIndex = 7;
            this.picStatePassWord.TabStop = false;
            this.picStatePassWord.Click += new System.EventHandler(this.picStatePassWord_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.lblUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUserName.Font = new System.Drawing.Font("Motley Forces", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Location = new System.Drawing.Point(58, 86);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(168, 51);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Username";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.lblPassWord, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPassWord.Font = new System.Drawing.Font("Motley Forces", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.ForeColor = System.Drawing.Color.Blue;
            this.lblPassWord.Location = new System.Drawing.Point(58, 210);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(168, 51);
            this.lblPassWord.TabIndex = 8;
            this.lblPassWord.Text = "PassWord";
            // 
            // btnSigning
            // 
            this.btnSigning.Active1 = System.Drawing.Color.Lime;
            this.btnSigning.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSigning.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.btnSigning, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSigning.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSigning.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigning.ForeColor = System.Drawing.Color.Black;
            this.btnSigning.Inactive1 = System.Drawing.Color.Transparent;
            this.btnSigning.Inactive2 = System.Drawing.Color.Transparent;
            this.btnSigning.Location = new System.Drawing.Point(250, 500);
            this.btnSigning.Name = "btnSigning";
            this.btnSigning.Radius = 20;
            this.btnSigning.Size = new System.Drawing.Size(152, 53);
            this.btnSigning.Stroke = true;
            this.btnSigning.StrokeColor = System.Drawing.Color.Lime;
            this.btnSigning.TabIndex = 10;
            this.btnSigning.Text = "SignIn";
            this.btnSigning.Transparency = false;
            // 
            // btnChanger
            // 
            this.btnChanger.Active1 = System.Drawing.Color.Cyan;
            this.btnChanger.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChanger.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.btnChanger, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnChanger.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChanger.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanger.ForeColor = System.Drawing.Color.Black;
            this.btnChanger.Inactive1 = System.Drawing.Color.Transparent;
            this.btnChanger.Inactive2 = System.Drawing.Color.Transparent;
            this.btnChanger.Location = new System.Drawing.Point(38, 500);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Radius = 20;
            this.btnChanger.Size = new System.Drawing.Size(193, 53);
            this.btnChanger.Stroke = true;
            this.btnChanger.StrokeColor = System.Drawing.Color.Cyan;
            this.btnChanger.TabIndex = 10;
            this.btnChanger.Text = "SignIn";
            this.btnChanger.Transparency = false;
            // 
            // txtRePass
            // 
            this.txtRePass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRePass.Animated = true;
            this.txtRePass.AutoRoundedCorners = true;
            this.txtRePass.BackColor = System.Drawing.Color.Transparent;
            this.txtRePass.BorderRadius = 26;
            this.txtRePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transTextBox.SetDecoration(this.txtRePass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRePass.DefaultText = "";
            this.txtRePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePass.FillColor = System.Drawing.Color.Silver;
            this.txtRePass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePass.Font = new System.Drawing.Font("NPINazaninTitr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.ForeColor = System.Drawing.Color.Black;
            this.txtRePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePass.Location = new System.Drawing.Point(16, 388);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '●';
            this.txtRePass.PlaceholderForeColor = System.Drawing.Color.Blue;
            this.txtRePass.PlaceholderText = "";
            this.txtRePass.SelectedText = "";
            this.txtRePass.Size = new System.Drawing.Size(252, 54);
            this.txtRePass.TabIndex = 11;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.BackColor = System.Drawing.Color.Transparent;
            this.transTextBox.SetDecoration(this.lblRePass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRePass.Font = new System.Drawing.Font("Motley Forces", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePass.ForeColor = System.Drawing.Color.Blue;
            this.lblRePass.Location = new System.Drawing.Point(12, 331);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(260, 51);
            this.lblRePass.TabIndex = 12;
            this.lblRePass.Text = "Repat PassWord";
            // 
            // pangradLOG
            // 
            this.pangradLOG.BackColor = System.Drawing.Color.Transparent;
            this.pangradLOG.BorderRadius = 50;
            this.pangradLOG.Controls.Add(this.lblRePass);
            this.pangradLOG.Controls.Add(this.txtRePass);
            this.pangradLOG.Controls.Add(this.btnChanger);
            this.pangradLOG.Controls.Add(this.btnSigning);
            this.pangradLOG.Controls.Add(this.lblPassWord);
            this.pangradLOG.Controls.Add(this.lblUserName);
            this.pangradLOG.Controls.Add(this.picStatePassWord);
            this.pangradLOG.Controls.Add(this.txtPassWord);
            this.pangradLOG.Controls.Add(this.txtUserName);
            this.transTextBox.SetDecoration(this.pangradLOG, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pangradLOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pangradLOG.FillColor = System.Drawing.Color.Red;
            this.pangradLOG.FillColor2 = System.Drawing.Color.Lime;
            this.pangradLOG.FillColor3 = System.Drawing.Color.Fuchsia;
            this.pangradLOG.FillColor4 = System.Drawing.Color.Blue;
            this.pangradLOG.Location = new System.Drawing.Point(0, 35);
            this.pangradLOG.Name = "pangradLOG";
            this.pangradLOG.Size = new System.Drawing.Size(420, 565);
            this.pangradLOG.TabIndex = 5;
            // 
            // Sgining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtaghMan.App.Properties.Resources.Them;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pangradLOG);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panHead);
            this.transTextBox.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sgining";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sgining_Load);
            this.panHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatePassWord)).EndInit();
            this.pangradLOG.ResumeLayout(false);
            this.pangradLOG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private AltoControls.AltoButton btnExit;
        private AltoControls.AltoButton btnMinimize;
        private AltoControls.AltoButton altoButton1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAppIcon;
        private System.Windows.Forms.Panel panRight;
        private Guna.UI2.WinForms.Guna2Transition transTextBox;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picStatePassWord;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassWord;
        private AltoControls.AltoButton btnSigning;
        private AltoControls.AltoButton btnChanger;
        private Guna.UI2.WinForms.Guna2TextBox txtRePass;
        private System.Windows.Forms.Label lblRePass;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pangradLOG;
    }
}

