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



        public frmMain()
        {
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
            if (txtSearchIsVisible)
            {
                txtSearch.Width = txtSearch.Width-10;
                if (txtSearch.Width ==0)
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
            rooms = new Rooms_tbl();
            List<Rooms_tbl> roomsList = new List<Rooms_tbl>();
            db = new RoomsUnit();
            roomsList = db.RoomsRepository.GetAllRooms().ToList();
            foreach (var room in roomsList)
            {
                CartGenerator(room.ROOM_ID,room.ROOM_NAME,room.ROOM_PIC);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAddEditRoom frmAdd = new frmAddEditRoom();
            frmAdd.ShowDialog();
        }
    }
}

