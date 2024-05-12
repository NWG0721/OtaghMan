using OtaghMan.Data.Context;
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

namespace OtaghMan.App.Forms
{
    public partial class frmStorages : Form
    {
        public void CartGenerator(int countOfStorages, string storageName)
        {

            WiLBiT.WiLBiTPanel panStorage_ = new WiLBiT.WiLBiTPanel();
            WiLBiT.WiLBiTTextBox txtStorageName_ = new WiLBiT.WiLBiTTextBox();
            Splitter splitBetween_ = new Splitter();


            // 
            // panStorage
            // 
            panStorage_.BackColor = System.Drawing.Color.Bisque;
            panStorage_.BorderColor = System.Drawing.Color.PaleVioletRed;
            panStorage_.BorderRadius = 15;
            panStorage_.BorderSize = 0;
            panStorage_.Dock = System.Windows.Forms.DockStyle.Top;
            panStorage_.ForeColor = System.Drawing.Color.White;
            panStorage_.Location = new System.Drawing.Point(0, 0);
            panStorage_.Name = "panStorage_" + countOfStorages;
            panStorage_.Size = new System.Drawing.Size(268, 121);
            panStorage_.TabIndex = 0;
            panStorage_.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panStorage_MouseClick);
            // 
            // txtStorageName
            // 
            txtStorageName_.BackColor = System.Drawing.Color.Bisque;
            txtStorageName_.BorderColor = System.Drawing.Color.Empty;
            txtStorageName_.BorderFocusColor = System.Drawing.Color.Empty;
            txtStorageName_.BorderRadius = 4;
            txtStorageName_.BorderSize = 2;
            txtStorageName_.Cursor = System.Windows.Forms.Cursors.Default;
            txtStorageName_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            txtStorageName_.ForeColor = System.Drawing.Color.Peru;
            txtStorageName_.Location = new System.Drawing.Point(89, 7);
            txtStorageName_.Margin = new System.Windows.Forms.Padding(4);
            txtStorageName_.Multiline = false;
            txtStorageName_.Name = "txtStorageName_" + countOfStorages;
            txtStorageName_.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            txtStorageName_.PasswordChar = false;
            txtStorageName_.PlaceholderColor = System.Drawing.Color.DarkGray;
            txtStorageName_.PlaceholderText = "";
            txtStorageName_.Size = new System.Drawing.Size(175, 38);
            txtStorageName_.TabIndex = 0;
            txtStorageName_.Texts = storageName;
            txtStorageName_.UnderlinedStyle = false;
            // 
            // splitBetween
            // 
            splitBetween_.Dock = System.Windows.Forms.DockStyle.Top;
            splitBetween_.Enabled = false;
            splitBetween_.Location = new System.Drawing.Point(0, 121);
            splitBetween_.Name = "splitBetween_" + countOfStorages;
            splitBetween_.Size = new System.Drawing.Size(268, 10);
            splitBetween_.TabIndex = 4;
            splitBetween_.TabStop = false;

            panContaneStorage.Controls.Add(panStorage_);
            panStorage_.Controls.Add(txtStorageName_);
            panContaneStorage.Controls.Add(splitBetween_);
        }
        public void EquipmentSlideGenerator(int countOfEquipment, string equipName, string equipOwner, string equipPic)
        {

            WiLBiT.WiLBiTPanel equipPan = new WiLBiT.WiLBiTPanel();
            PictureBox picEquip = new System.Windows.Forms.PictureBox();
            WiLBiT.WiLBiTTextBox txtEquipName = new WiLBiT.WiLBiTTextBox();
            AltoControls.AltoButton btnEquipEdit = new AltoControls.AltoButton();
            AltoControls.AltoButton btnDeleteEquip = new AltoControls.AltoButton();
            WiLBiT.WiLBiTTextBox txtEquipOwner = new WiLBiT.WiLBiTTextBox();

            // 
            // equipPan
            // 
            equipPan.BackColor = System.Drawing.Color.Bisque;
            equipPan.BorderColor = System.Drawing.Color.Peru;
            equipPan.BorderRadius = 25;
            equipPan.BorderSize = 3;
            equipPan.ForeColor = System.Drawing.Color.White;
            equipPan.Location = new System.Drawing.Point(35, 24);
            equipPan.Margin = new System.Windows.Forms.Padding(24);
            equipPan.Name = "equipPan" + countOfEquipment;
            equipPan.Size = new System.Drawing.Size(873, 178);
            equipPan.TabIndex = 6;
            // 
            // picEquip
            // 
            picEquip.BackColor = System.Drawing.Color.Transparent;
            picEquip.Dock = System.Windows.Forms.DockStyle.Right;
            picEquip.Location = new System.Drawing.Point(634, 0);
            picEquip.Name = "picEquip" + countOfEquipment;
            picEquip.Size = new System.Drawing.Size(239, 178);
            picEquip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picEquip.TabIndex = 0;
            picEquip.TabStop = false;
            picEquip.ImageLocation = equipPic;
            // 
            // txtEquipName
            // 
            txtEquipName.BackColor = System.Drawing.Color.Bisque;
            txtEquipName.BorderColor = System.Drawing.Color.Empty;
            txtEquipName.BorderFocusColor = System.Drawing.Color.Empty;
            txtEquipName.BorderRadius = 4;
            txtEquipName.BorderSize = 2;
            txtEquipName.Cursor = System.Windows.Forms.Cursors.Default;
            txtEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            txtEquipName.ForeColor = System.Drawing.Color.Peru;
            txtEquipName.Location = new System.Drawing.Point(432, 10);
            txtEquipName.Margin = new System.Windows.Forms.Padding(4);
            txtEquipName.Multiline = false;
            txtEquipName.Name = "txtEquipName" + countOfEquipment;
            txtEquipName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            txtEquipName.PasswordChar = false;
            txtEquipName.PlaceholderColor = System.Drawing.Color.DarkGray;
            txtEquipName.PlaceholderText = "";
            txtEquipName.Size = new System.Drawing.Size(195, 38);
            txtEquipName.TabIndex = 2;
            txtEquipName.Texts = equipName;
            txtEquipName.UnderlinedStyle = false;
            // 
            // btnEquipEdit
            // 
            btnEquipEdit.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            btnEquipEdit.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            btnEquipEdit.BackColor = System.Drawing.Color.Transparent;
            btnEquipEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnEquipEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEquipEdit.ForeColor = System.Drawing.Color.Peru;
            btnEquipEdit.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            btnEquipEdit.Inactive2 = System.Drawing.Color.Transparent;
            btnEquipEdit.Location = new System.Drawing.Point(31, 10);
            btnEquipEdit.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            btnEquipEdit.Name = "btnEquipEdit" + countOfEquipment;
            btnEquipEdit.Radius = 10;
            btnEquipEdit.Size = new System.Drawing.Size(168, 67);
            btnEquipEdit.Stroke = true;
            btnEquipEdit.StrokeColor = System.Drawing.Color.Peru;
            btnEquipEdit.TabIndex = 20;
            btnEquipEdit.Text = "تصحیح";
            btnEquipEdit.Transparency = false;
            // 
            // btnDeleteEquip
            // 
            btnDeleteEquip.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            btnDeleteEquip.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            btnDeleteEquip.BackColor = System.Drawing.Color.Transparent;
            btnDeleteEquip.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnDeleteEquip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDeleteEquip.ForeColor = System.Drawing.Color.Peru;
            btnDeleteEquip.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            btnDeleteEquip.Inactive2 = System.Drawing.Color.Transparent;
            btnDeleteEquip.Location = new System.Drawing.Point(31, 102);
            btnDeleteEquip.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            btnDeleteEquip.Name = "btnDeleteEquip" + countOfEquipment;
            btnDeleteEquip.Radius = 10;
            btnDeleteEquip.Size = new System.Drawing.Size(168, 67);
            btnDeleteEquip.Stroke = true;
            btnDeleteEquip.StrokeColor = System.Drawing.Color.Peru;
            btnDeleteEquip.TabIndex = 21;
            btnDeleteEquip.Text = "پاکیدن";
            btnDeleteEquip.Transparency = false;
            // 
            // txtEquipOwner
            // 
            txtEquipOwner.BackColor = System.Drawing.Color.Bisque;
            txtEquipOwner.BorderColor = System.Drawing.Color.Empty;
            txtEquipOwner.BorderFocusColor = System.Drawing.Color.Empty;
            txtEquipOwner.BorderRadius = 4;
            txtEquipOwner.BorderSize = 2;
            txtEquipOwner.Cursor = System.Windows.Forms.Cursors.Default;
            txtEquipOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            txtEquipOwner.ForeColor = System.Drawing.Color.Peru;
            txtEquipOwner.Location = new System.Drawing.Point(432, 101);
            txtEquipOwner.Margin = new System.Windows.Forms.Padding(4);
            txtEquipOwner.Multiline = false;
            txtEquipOwner.Name = "txtEquipOwner" + countOfEquipment;
            txtEquipOwner.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            txtEquipOwner.PasswordChar = false;
            txtEquipOwner.PlaceholderColor = System.Drawing.Color.DarkGray;
            txtEquipOwner.PlaceholderText = "";
            txtEquipOwner.Size = new System.Drawing.Size(195, 38);
            txtEquipOwner.TabIndex = 2;
            txtEquipOwner.Texts = equipOwner;
            txtEquipOwner.UnderlinedStyle = false;

            lpcEquipments.Controls.Add(equipPan);
            equipPan.Controls.Add(picEquip);
            equipPan.Controls.Add(txtEquipName);
            equipPan.Controls.Add(btnEquipEdit);
            equipPan.Controls.Add(btnDeleteEquip);
            equipPan.Controls.Add(txtEquipOwner);



        }
        public void SlideCaller(int storageID)
        {
            equipmentUnit = new EquipmentUnit();
            lpcEquipments.Controls.Clear();
            usersUnit = new UsersUnit();
            if (index != 0)
            {
                listOfEquipment = equipmentUnit.EquipmentRepository.FindEquipmentByStorageID(storageID).ToList();
                foreach (var slide in listOfEquipment)
                {

                    EquipmentSlideGenerator(slide.EQUIPMENT_ID, slide.EQUIPMENT_NAME, usersUnit.UsersRopository.GetUserByID(slide.EQUIPMENT_OWNER).USER_USERNAME, slide.EQUIPMENT_PIC);

                }
            }
            else
            {
                MessageBox.Show("لطفا یکی از محل های نگهداری را انتخاب کنید");
            }
            equipmentUnit.Dispose();
            db.Dispose();
            usersUnit.Dispose();
        }

        public void CartCaller()
        {
            db = new StorageUnit();
            panContaneStorage.Controls.Clear();
            listOfStorages = db.StorageRepository.GetStorages(roomID);
            foreach (var cart in listOfStorages)
            {
                CartGenerator(cart.STORAGE_ID, cart.STORAGE_NAME);

            }
            db.Dispose();
        }
    }
}
