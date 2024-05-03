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
    public partial class frmClickRightForStorageAndEquip : Form
    {
        int index;
        StorageUnit db;
        public frmClickRightForStorageAndEquip(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db = new StorageUnit();
            if (MessageBox.Show("آیا از فضای ذخیره سازی خود سیر شده اید؟ و می خواهید آن را پاک کیند؟؟", "وایسا ببینم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db.StorageRepository.DeleteStorage(index);
                db.SaveChanges();
                db.Dispose();
                this.Close();
                DialogResult = DialogResult.Yes;
            }
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            Storages_tbl storages = new Storages_tbl()
            {
                STORAGE_ID = index,

                STORAGE_NAME = txtStorageOrEquipmentName.Text,
            };
            bool isChange = db.StorageRepository.UpdateStorageInfo(storages);
            db.SaveChanges();
            db.Dispose();
            this.Close();
            DialogResult = DialogResult.Yes;
        }

        private void frmClickRightForStorageAndEquip_Load(object sender, EventArgs e)
        {
            this.Location = Cursor.Position;
        }
    }
}
