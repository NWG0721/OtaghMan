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
using System.IO;
using System.Diagnostics;
using OtaghMan.Data;
using OtaghMan.Data.Context;
using System.Reflection;
using System.Web.UI.WebControls;
using OtaghMan.App.Forms;


namespace OtaghMan.App
{
    public partial class frmMain : Form
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


        Rooms_tbl rooms;
        RoomsUnit db;
        public int index = 0;
        int userID;


        public frmMain(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblManageRoom_Click(object sender, EventArgs e)
        {
            frmAddEditRoom editRooms = new frmAddEditRoom();
            editRooms.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }


        bool txtSearchIsVisible = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSearch.Texts = "";
            if (txtSearchIsVisible)
            {
                txtSearch.Width = txtSearch.Width - 10;
                if (txtSearch.Width == 0)
                {
                    txtSearch.Visible = !txtSearch.Visible;
                    txtSearchIsVisible = false;
                    timer1.Enabled = false;
                }
            }
            else
            {
                txtSearch.Visible = !txtSearch.Visible;
                txtSearch.Width = txtSearch.Width + 10;
                if (txtSearch.Width == 250)
                {
                    txtSearchIsVisible = true;
                    timer1.Enabled = false;
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh() {
            CartCaller();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAddEditRoom frmAdd = new frmAddEditRoom();
            frmAdd.ShowDialog();
            Refresh();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        




        private int GetIndexFromButtonName(string name, string fullName)
        {


            if (name.StartsWith(fullName))

            {

                string indexStr = name.Substring(fullName.Length);

                if (int.TryParse(indexStr, out int index))

                {

                    return index;

                }

            }

            return -1;

        }

        private void btnOpenRooms_MouseClick(object sender, MouseEventArgs e)
        {
            WiLBiT.WiLBiTButton btn = sender as WiLBiT.WiLBiTButton;
            index = GetIndexFromButtonName(btn.Name, "btnOpenRoom_");
            Rooms_tbl room = new Rooms_tbl(); 
            room = db.RoomsRepository.GetRoomByID(index);
            if (e.Button == MouseButtons.Left)
            {
                frmStorages storages = new frmStorages(room , userID);
                this.Hide();
                storages.ShowDialog();
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            db = new RoomsUnit();
            
            foreach (var room in db.RoomsRepository.GetRoomsByFillter(txtSearch.Texts))
            {
                CartGenerator(room.ROOM_ID, room.ROOM_NAME, room.ROOM_PIC);
            }

        }



        private void btnManageRooms_MouseClick(object sender, MouseEventArgs e)
        {
            WiLBiT.WiLBiTButton btn = sender as WiLBiT.WiLBiTButton;
            index = GetIndexFromButtonName(btn.Name, "btnManageRoom_");
            if (e.Button == MouseButtons.Left)
            {
                frmManage manage = new frmManage(index);
                manage.Show();
                if (manage.DialogResult == DialogResult.Yes)
                {
                    Refresh();
                    MessageBox.Show("OK");
                    Refresh();
                }
            }
        }
    }
}

