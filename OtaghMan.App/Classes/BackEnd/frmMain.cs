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

namespace OtaghMan.App
{
    public partial class frmMain
    {
        public void CartGenerator(int countOfRooms, string roomName, string roomPic)
        {
            //------------------|  |------------------//
            WiLBiT.WiLBiTGradientPanel panRoom_ = new WiLBiT.WiLBiTGradientPanel();
            WiLBiT.WiLBiTButton btnOpenRoom_ = new WiLBiT.WiLBiTButton();
            WiLBiT.WiLBiTButton btnManageRoom_ = new WiLBiT.WiLBiTButton();
            TextBox txtRoomName_ = new TextBox();
            PictureBox picRoom_ = new PictureBox();
            Splitter splitter6_ = new Splitter();

            //------------------|  |------------------//
            // 
            // panRoom
            // 
            panRoom_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            panRoom_.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            panRoom_.BorderColor = System.Drawing.Color.Peru;
            panRoom_.BorderRadius = 15;
            panRoom_.BorderSize = 2;
            panRoom_.Dock = System.Windows.Forms.DockStyle.Right;
            panRoom_.ForeColor = System.Drawing.Color.Peru;
            panRoom_.Location = new System.Drawing.Point(552 * countOfRooms, 0);
            panRoom_.Name = "panRoom_" + countOfRooms;
            panRoom_.Size = new System.Drawing.Size(383, 419);
            panRoom_.TabIndex = 4;
            // 
            // btnOpenRoom
            // 
            btnOpenRoom_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            btnOpenRoom_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            btnOpenRoom_.BorderRadius = 15;
            btnOpenRoom_.BorderSize = 2;
            btnOpenRoom_.FlatAppearance.BorderSize = 0;
            btnOpenRoom_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenRoom_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOpenRoom_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            btnOpenRoom_.Location = new System.Drawing.Point(6, 361);
            btnOpenRoom_.Name = "btnOpenRoom_" + countOfRooms;
            btnOpenRoom_.Size = new System.Drawing.Size(169, 51);
            btnOpenRoom_.TabIndex = 5;
            btnOpenRoom_.Text = "بازکردن";
            btnOpenRoom_.UseVisualStyleBackColor = false;
            // 
            // btnManageRoom
            // 
            btnManageRoom_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            btnManageRoom_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            btnManageRoom_.BorderRadius = 15;
            btnManageRoom_.BorderSize = 2;
            btnManageRoom_.FlatAppearance.BorderSize = 0;
            btnManageRoom_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnManageRoom_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnManageRoom_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            btnManageRoom_.Location = new System.Drawing.Point(208, 361);
            btnManageRoom_.Name = "btnManageRoom_" + countOfRooms;
            btnManageRoom_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnManageRoom_.Size = new System.Drawing.Size(169, 51);
            btnManageRoom_.TabIndex = 5;
            btnManageRoom_.Text = "مدیریت";
            btnManageRoom_.UseVisualStyleBackColor = false;
            btnManageRoom_.Click += new System.EventHandler(this.lblManageRoom_Click);
            // 
            // lblRoomName
            // 
            txtRoomName_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            txtRoomName_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtRoomName_.Cursor = System.Windows.Forms.Cursors.Default;
            txtRoomName_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            txtRoomName_.ForeColor = System.Drawing.Color.Peru;
            txtRoomName_.Location = new System.Drawing.Point(190, 251);
            txtRoomName_.Name = "txtRoomName_" + countOfRooms;
            txtRoomName_.ReadOnly = true;
            txtRoomName_.Size = new System.Drawing.Size(187, 40);
            txtRoomName_.TabIndex = 10;
            txtRoomName_.Text = "اتاق " + roomName;
            txtRoomName_.ReadOnly = true;


            // 
            // picRoom
            // 
            picRoom_.BackColor = System.Drawing.Color.Silver;
            picRoom_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picRoom_.Dock = System.Windows.Forms.DockStyle.Top;
            picRoom_.Location = new System.Drawing.Point(0, 0);
            picRoom_.Name = "picRoom_" + countOfRooms;
            picRoom_.Size = new System.Drawing.Size(383, 228);
            picRoom_.TabIndex = 1;
            picRoom_.TabStop = false;
            picRoom_.ImageLocation = roomPic;
            picRoom_.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // splitter6
            // 
            splitter6_.Dock = System.Windows.Forms.DockStyle.Right;
            splitter6_.Enabled = false;
            splitter6_.Location = new System.Drawing.Point(533, 0);
            splitter6_.Name = "splitter6" + countOfRooms;
            splitter6_.Size = new System.Drawing.Size(19, 419);
            splitter6_.TabIndex = 9;
            splitter6_.TabStop = false;



            panContaner.Controls.Add(panRoom_);


            panRoom_.Controls.Add(txtRoomName_);

            panRoom_.Controls.Add(picRoom_);

            panContaner.Controls.Add(splitter6_);

            panRoom_.Controls.Add(btnOpenRoom_);

            panRoom_.Controls.Add(btnManageRoom_);


        }

        public void CartCaller()
        {
            panContaner.Controls.Clear();
            db = new RoomsUnit();
            foreach (var cart in db.RoomsRepository.GetAllRooms()) {
                CartGenerator(cart.ROOM_ID,cart.ROOM_NAME,cart.ROOM_PIC);
            
            }
        }
    }
}
