using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

            if (txtPassWord.PasswordChar != '\0')
            {
                this.picStatePassWord.Image = global::OtaghMan.App.Properties.Resources.icons8_hide_48;
                //picStatePassWord.ImageLocation = @"..\Media\Pictures\icons8_hide_48";
                txtPassWord.PasswordChar = '\0';
                txtRePass.PasswordChar = '\0';

            }
            else
            {
                this.picStatePassWord.Image = global::OtaghMan.App.Properties.Resources.icons8_view_48;
                //picStatePassWord.ImageLocation = @"..\Media\Pictures\icons8_hide_48";
                txtPassWord.PasswordChar = '●';
                txtRePass.PasswordChar = '●';

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
    }
}
