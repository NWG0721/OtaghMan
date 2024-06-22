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
using System.Web.UI.WebControls;
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
        int equipID = 0;
        string roomName;
        int roomID;
        int userID;
        frmAddEquip addEquip;
        StorageUnit db;
        EquipmentUnit equipmentUnit;
        UsersUnit usersUnit;
        public List<Storages_tbl> listOfStorages = new List<Storages_tbl>();
        public List<Equipment_tbl> listOfEquipment = new List<Equipment_tbl>();




        public frmStorages(Rooms_tbl rooms, int userID)
        {
            this.userID = userID;
            InitializeComponent();
            roomName = rooms.ROOM_NAME.ToString();
            roomID = rooms.ROOM_ID;
        }


        private int GetIndexFromPanelName(string name, string prefix)
        {

            if (name.StartsWith(prefix))

            {

                string indexStr = name.Substring(prefix.Length);

                if (int.TryParse(indexStr, out int index))

                {

                    return index;

                }
                else
                {

                    return -1;

                }
            }
            else
            {

                return -1;

            }
        }
        private void panStorage_MouseClick(object sender, MouseEventArgs e)
        {
            db = new StorageUnit();
            WiLBiTPanel panel = sender as WiLBiTPanel;

            index = GetIndexFromPanelName(panel.Name, "panStorage_");

            if (e.Button == MouseButtons.Right)
            {
                frmClickRightForStorageAndEquip fCRFSAE = new frmClickRightForStorageAndEquip(index, roomID);

                fCRFSAE.ShowDialog();
                if (fCRFSAE.DialogResult == DialogResult.OK)
                {
                    CartCaller();
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                equipmentUnit = new EquipmentUnit();
                lblStorageName.Text = db.StorageRepository.GetStorageByID(index).STORAGE_NAME;
                equipmentUnit.EquipmentRepository.GetTheActualEquipments(index, userID);
                equipmentUnit.Dispose();
                SlideCaller(index);
            }
            CartCaller();
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
            CartCaller();
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            CartCaller();
        }

        private void lblRoomName_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain(userID);
            main.Show();
        }

        private void btnAddNewEquip_Click(object sender, EventArgs e)
        {
            addEquip = new frmAddEquip(roomID, 0);
            addEquip.ShowDialog();
            SlideCaller(index);
        }

        private void altoButton2_Click(object sender, EventArgs e)
        {
            SlideCaller(index);
        }

        private void btnDeleteEquip_MouseClick(object sender, MouseEventArgs e)
        {
            AltoControls.AltoButton button = sender as AltoControls.AltoButton;
            equipmentUnit = new EquipmentUnit();
            equipID = GetIndexFromPanelName(button.Name, "btnDeleteEquip");
            bool isOk = equipmentUnit.EquipmentRepository.DeleteEquipment(equipID);
            if (isOk)
            {
                equipmentUnit.Dispose();
                index = 0;
                SlideCaller(index);
            }

        }

        private void btnEquipEdit_MouseClick(object sender, MouseEventArgs e)
        {
            AltoControls.AltoButton button = sender as AltoControls.AltoButton;
            equipmentUnit = new EquipmentUnit();
            addEquip = new frmAddEquip(roomID, GetIndexFromPanelName(button.Name, "btnEquipEdit"));
            index = 0;
            addEquip.ShowDialog();
            equipmentUnit.Dispose();
        }

        private void btnEquipEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
