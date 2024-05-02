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
        public void CartGenerator(int countOfRooms, string userName)
        {
            //------------------|  |------------------//
            this.panRoom = new WiLBiT.WiLBiTGradientPanel();
            this.btnOpenRoom = new WiLBiT.WiLBiTButton();
            this.btnManageRoom = new WiLBiT.WiLBiTButton();
            this.lblRoomName = new Label();
            this.picRoom = new PictureBox();
            this.splitter6 = new Splitter();
            //------------------|  |------------------//
            // 
            // panRoom
            // 
            this.panRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.panRoom.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panRoom.BorderColor = System.Drawing.Color.Peru;
            this.panRoom.BorderRadius = 15;
            this.panRoom.BorderSize = 2;
            this.panRoom.Controls.Add(this.btnOpenRoom);
            this.panRoom.Controls.Add(this.btnManageRoom);
            this.panRoom.Controls.Add(this.lblRoomName);
            this.panRoom.Controls.Add(this.picRoom);
            this.panRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRoom.ForeColor = System.Drawing.Color.Peru;
            this.panRoom.Location = new System.Drawing.Point(552* countOfRooms, 0);
            this.panRoom.Name = "panRoom"+ countOfRooms;
            this.panRoom.Size = new System.Drawing.Size(383, 419);
            this.panRoom.TabIndex = 4;
            // 
            // btnOpenRoom
            // 
            this.btnOpenRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnOpenRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnOpenRoom.BorderRadius = 15;
            this.btnOpenRoom.BorderSize = 2;
            this.btnOpenRoom.FlatAppearance.BorderSize = 0;
            this.btnOpenRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnOpenRoom.Location = new System.Drawing.Point(6, 354);
            this.btnOpenRoom.Name = "btnOpenRoom" + countOfRooms;
            this.btnOpenRoom.Size = new System.Drawing.Size(169, 51);
            this.btnOpenRoom.TabIndex = 5;
            this.btnOpenRoom.Text = "بازکردن";
            this.btnOpenRoom.UseVisualStyleBackColor = false;
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnManageRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnManageRoom.BorderRadius = 15;
            this.btnManageRoom.BorderSize = 2;
            this.btnManageRoom.FlatAppearance.BorderSize = 0;
            this.btnManageRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnManageRoom.Location = new System.Drawing.Point(208, 354);
            this.btnManageRoom.Name = "btnManageRoom" + countOfRooms;
            this.btnManageRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnManageRoom.Size = new System.Drawing.Size(169, 51);
            this.btnManageRoom.TabIndex = 5;
            this.btnManageRoom.Text = "مدیریت";
            this.btnManageRoom.UseVisualStyleBackColor = false;
            this.btnManageRoom.Click += new System.EventHandler(this.lblManageRoom_Click);
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRoomName.Location = new System.Drawing.Point(313, 247);
            this.lblRoomName.Name = "lblRoomName" + countOfRooms;
            this.lblRoomName.Size = new System.Drawing.Size(43, 25);
            this.lblRoomName.TabIndex = 3;
            this.lblRoomName.Text = "اتاق"+ countOfRooms;
            // 
            // picRoom
            // 
            this.picRoom.BackColor = System.Drawing.Color.Silver;
            this.picRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.picRoom.Location = new System.Drawing.Point(0, 0);
            this.picRoom.Name = "picRoom" + countOfRooms;
            this.picRoom.Size = new System.Drawing.Size(383, 228);
            this.picRoom.TabIndex = 1;
            this.picRoom.TabStop = false;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter6.Enabled = false;
            this.splitter6.Location = new System.Drawing.Point(533, 0);
            this.splitter6.Name = "splitter6" + countOfRooms;
            this.splitter6.Size = new System.Drawing.Size(19, 419);
            this.splitter6.TabIndex = 9;
            this.splitter6.TabStop = false;




            panContaner.Controls.Add(panRoom);

            panRoom.Controls.Add(btnOpenRoom);

            panRoom.Controls.Add(btnManageRoom);

            panRoom.Controls.Add(lblRoomName);

            panRoom.Controls.Add(picRoom);

            panContaner.Controls.Add(splitter6);


        }
    }
}
