using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtaghMan.Data;
using OtaghMan.Data.Context;

namespace OtaghMan.App
{
    public partial class frmManage : Form
    {
        string finalPath;

        int foreiginIndex;

        RoomsUnit db = new RoomsUnit();

        //////////////////////////////////////

        public frmManage(int index)
        {
            InitializeComponent();
            foreiginIndex = index;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            db.Dispose();
            this.Close();
        }
        private void frmManage_Load(object sender, EventArgs e)
        {
            txtRoomName.Text = db.RoomsRepository.GetRoomByID(foreiginIndex).ROOM_NAME;
            picRoomPicture.ImageLocation = db.RoomsRepository.GetRoomByID(foreiginIndex).ROOM_PIC;
            finalPath = picRoomPicture.ImageLocation;
            DialogResult = DialogResult.No;

        }

        string uniqueFileName;
        string imagePath = "";
        string dirPath = Application.StartupPath + "/Images/Rooms";
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.png;*.jpg;*.jpeg;*.bmp;*.heic;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);

                }
                uniqueFileName = Guid.NewGuid() + Path.GetExtension(imagePath);
                finalPath = dirPath + '/' + uniqueFileName;
                File.Copy(imagePath, finalPath);
                picRoomPicture.ImageLocation = finalPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Rooms_tbl room = new Rooms_tbl()
            {
                ROOM_ID = foreiginIndex,

                ROOM_NAME = txtRoomName.Text,

                ROOM_PIC = finalPath
            };
           bool isChange =  db.RoomsRepository.UpdateRoomInfo(room);
            db.SaveChanges();
            db.Dispose();
            this.Close();
            DialogResult = DialogResult.Yes;
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از اتاق خود سیر شده اید؟ و می خواهید آن را پاک کیند؟؟", "وایسا ببینم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db.RoomsRepository.DeleteRoom(foreiginIndex);
                db.SaveChanges();
                db.Dispose();
                this.Close();
                DialogResult = DialogResult.Yes;
            }
        }
    }
}
