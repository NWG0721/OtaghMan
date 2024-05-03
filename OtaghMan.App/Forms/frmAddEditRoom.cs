using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OtaghMan.Data.Context;
using OtaghMan.Data;

namespace OtaghMan.App
{
    public partial class frmAddEditRoom : Form
    {
        public frmAddEditRoom()
        {
            InitializeComponent();
        }
        string uniqueFileName;
        RoomsUnit db = new RoomsUnit();

        string imagePath = "";
        string dirPath = Application.StartupPath + "/Images/Rooms";
        string finalPath ;
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
                uniqueFileName = Guid.NewGuid()+Path.GetExtension(imagePath);
                finalPath = dirPath + '/' + uniqueFileName;
                File.Copy(imagePath, finalPath);
                picRoomPicture.ImageLocation = finalPath;
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            Rooms_tbl room = new Rooms_tbl()
            {
                ROOM_NAME = txtRoomName.Text,

                ROOM_PIC = finalPath
            };
            db.RoomsRepository.AddRoom(room);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            db.Dispose();
            this.Close();
        }

        private void frmAddEditRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
/*
 
 
 
 */