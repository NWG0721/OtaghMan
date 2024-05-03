using OtaghMan.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace OtaghMan.App.Forms
{
    public partial class frmStorages : Form
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        //For moving form
        //

        public int index = 0;

        public frmStorages(Rooms_tbl rooms)
        {

            lblRoomName.Text = rooms.ROOM_NAME.ToString();
            InitializeComponent();
        }


        private int GetIndexFromPanelName(string name)

        {

            string prefix = "panPerson";

            if (name.StartsWith(prefix))

            {

                string indexStr = name.Substring(prefix.Length);

                if (int.TryParse(indexStr, out int index))

                {

                    return index;

                }

            }

            return -1;

        }
        private void panStorage_MouseClick(object sender, MouseEventArgs e)
        {
            WiLBiTPanel panel = sender as WiLBiTPanel;
            index = GetIndexFromPanelName(panel.Name);
            if (e.Button == MouseButtons.Right)
            {
                frmClickRightForStorageAndEquip fCRFSAE = new frmClickRightForStorageAndEquip(index);
                fCRFSAE.ShowDialog();
                fCRFSAE.Location = Cursor.Position;
            }
            if (e.Button == MouseButtons.Left)
            {
             
            }
        }
    }
}
