using OtaghMan.Data;
using OtaghMan.Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtaghMan.App
{
    public partial class Sgining : Form
    {
        //
        //For moving form
        //
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xF010;

        int height = Screen.PrimaryScreen.Bounds.Height;
        int width = Screen.PrimaryScreen.Bounds.Width;

        public void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE | 0x2, 0);
            }
        }
        //
        //For moving form
        //


        public Sgining()
        {
            InitializeComponent();
        }

        private void Sgining_Load(object sender, EventArgs e)
        {

        }
        private void picStatePassWord_Click(object sender, EventArgs e)
        {

            if (txtPassWord.PasswordChar)
            {
                this.picStatePassWord.Image = global::OtaghMan.App.Properties.Resources.icons8_hide_48;
                //picStatePassWord.ImageLocation = @"..\Media\Pictures\icons8_hide_48";
                txtPassWord.PasswordChar = false;
                txtRePass.PasswordChar = false;

            }
            else
            {
                picStatePassWord.Image = global::OtaghMan.App.Properties.Resources.icons8_view_48;
                //picStatePassWord.ImageLocation = @"..\Media\Pictures\icons8_hide_48";
                txtPassWord.PasswordChar = true;
                txtRePass.PasswordChar = true;

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        bool signIned = true;
        private void btnSignInOrSignUp_Click(object sender, EventArgs e)
        {
            txtRePass.Visible = !txtRePass.Visible;
            lblRePass.Visible = !lblRePass.Visible;
            if (signIned)
            {
                btnSignInOrSignUp.Text = "میخوام ورود کنم";
                btnEnter.Text = "ثبت نام";
                signIned = false;
            }
            else
            {
                btnSignInOrSignUp.Text = "میخوام ثبت نام کنم";
                btnEnter.Text = "ورود";
                signIned = true;
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            Users_tbl user = new Users_tbl();
            
            using (UsersUnit db = new UsersUnit())
            {
                if (signIned)
                {
                    user = db.UsersRopository.IsHere(txtUserName.Texts, txtPassWord.Texts);
                    if (user == null)
                    {
                        lblBadUserPass.Visible = true;
                        lblBadUserPass.Text = "نام کاربری یا رمز عبور یکی نیستن گلم";
                    }
                    else
                    {
                        lblBadUserPass.Visible = false;
                        Thread.Sleep(2000);
                        this.Hide();
                        main.Show();
                    }
                }
                else
                {
                    user = db.UsersRopository.IsHere(txtUserName.Texts);
                    if (user != null)
                    {
                        lblBadUserPass.Visible = true;
                       lblBadUserPass.Text = "یکی قبلا از یوزرت اسکی رفته مشتی";
                    }
                    else
                    {
                        if (txtRePass.Texts == txtPassWord.Texts)
                        {
                            Users_tbl adduser = new Users_tbl() { 
                            USER_USERNAME = txtUserName.Texts,
                            USER_PASSWORD = txtPassWord.Texts
                            };

                            lblBadUserPass.Visible = false;
                            if (!db.UsersRopository.AddUser(adduser))
                            {
                                MessageBox.Show("یه مشکلی هست جون دل", "گند خورد به کار کیومرث", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                db.UsersRopository.SaveChanges();
                                MessageBox.Show("اضافه شدی جون دل", "کار دراومد کیومرث", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Thread.Sleep(2000);
                                this.Hide();
                                main.Show();
                            }


                        }
                    }

                }

            }
        }


    }
}
