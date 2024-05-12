using OtaghMan.App.Classes.BackEnd;
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

namespace OtaghMan.App.Forms
{
    public partial class frmAddEquip : Form
    {
        int roomID;
        int equipID;
        public frmAddEquip(int roomID, int equipID)
        {
            EquipmentUnit db = new EquipmentUnit();
            this.roomID = roomID;
            this.equipID = equipID;
            if (equipID != 0)
            {
                var res = db.EquipmentRepository.GetEquipmentByID(equipID);
                txtEquipName.Text = res.EQUIPMENT_NAME;
                comboEquipOwner.SelectedItem = res.EQUIPMENT_OWNER;
                comboStorageName.SelectedItem = res.EQUIPMENT_STORAGE;
                finalPath = res.EQUIPMENT_PIC;
            }
            InitializeComponent();
        }

        UsersUnit UU = new UsersUnit();
        StorageUnit SU = new StorageUnit();

        private void frmAddEquip_Load(object sender, EventArgs e)
        {
            comboEquipOwner.Items.Clear();
            comboStorageName.Items.Clear();


            foreach (var uu in UU.UsersRopository.GetAllUsers())
            {
                comboEquipOwner.Items.Add(uu.USER_USERNAME);
            }
            foreach (var su in SU.StorageRepository.GetStorageByRoom(roomID))
            {
                comboStorageName.Items.Add(su.STORAGE_NAME);
            }
        }
        string finalPath;
        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.heic)|*.png;*.jpg;*.jpeg;*.gif;*.bmp;*.heic";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picEquip.ImageLocation = ofd.FileName;
                finalPath = FileWorker.PicAddressGenerator(picEquip.ImageLocation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                EquipmentUnit db = new EquipmentUnit();
            Equipment_tbl equipment_Tbl;
            if (equipID != 0)
            {
                equipment_Tbl = new Equipment_tbl()
                {
                    EQUIPMENT_NAME = txtEquipName.Text,
                    EQUIPMENT_OWNER = UU.UsersRopository.IsHere(comboEquipOwner.SelectedItem.ToString()).USER_ID,
                    EQUIPMENT_STORAGE = SU.StorageRepository.GetStorageByName(comboStorageName.SelectedItem.ToString(), roomID).STORAGE_ID,
                    EQUIPMENT_PIC = finalPath
                };
                db.EquipmentRepository.UpdateEquipmentInfo(equipment_Tbl);
            }
            else
            {
                equipment_Tbl = new Equipment_tbl()
                {
                    EQUIPMENT_NAME = txtEquipName.Text,
                    EQUIPMENT_OWNER = UU.UsersRopository.IsHere(comboEquipOwner.SelectedItem.ToString()).USER_ID,
                    EQUIPMENT_STORAGE = SU.StorageRepository.GetStorageByName(comboStorageName.SelectedItem.ToString(), roomID).STORAGE_ID,
                    EQUIPMENT_PIC = finalPath
                };

                db.EquipmentRepository.AddEquipment(equipment_Tbl);
            }
                db.SaveChanges();
                db.Dispose();

        }
    }
}
