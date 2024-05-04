using OtaghMan.Data;
using OtaghMan.Data.Context;
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
        string roomName;
        int roomID;

        StorageUnit db;


        public frmStorages(Rooms_tbl rooms)
        {

            InitializeComponent();
            roomName = rooms.ROOM_NAME.ToString();
            roomID = rooms.ROOM_ID;
        }


        private int GetIndexFromPanelName(string name)
        {

            string prefix = "panStorage_";

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
                if (fCRFSAE.DialogResult == DialogResult.OK)
                {
                    CartCaller();
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                db = new StorageUnit();
                var storageName = db.StorageRepository.GetStorageByID(index);
                Storages_tbl stb = db.StorageRepository.GetStorageByID(index);
                lblStorageName.Text = storageName.STORAGE_NAME;
            }
        }

        private void frmStorages_Load(object sender, EventArgs e)
        {
            lblRoomName.Text = roomName;
            CartCaller();
        }

        private void btnAddStorage_Click(object sender, EventArgs e)
        {
            frmAddStorage AddStorage = new frmAddStorage(roomID);
            AddStorage.ShowDialog();
            if (AddStorage.DialogResult == DialogResult.OK)
            {
                CartCaller();
            }
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            CartCaller();
        }

        private void lblRoomName_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
