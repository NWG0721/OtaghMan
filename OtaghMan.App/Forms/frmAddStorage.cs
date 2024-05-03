using OtaghMan.Data;
using OtaghMan.Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtaghMan.App
{
    public partial class frmAddStorage : Form
    {
        int roomID;
        public frmAddStorage(int roomID)
        {
            this.roomID = roomID;
            InitializeComponent();
        }

        private void txtAddStorage_Click(object sender, EventArgs e)
        {
            StorageUnit db = new StorageUnit();
            Storages_tbl storage = new Storages_tbl()
            {
                STORAGE_NAME = txtRoomName.Text,
                ROOM_ID = roomID
            };
            db.StorageRepository.AddStorage(storage);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
