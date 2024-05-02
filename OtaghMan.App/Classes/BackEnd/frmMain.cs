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
        public void CartGenerator(int countOfRooms,string userName)
        {
            panRoom = new WiLBiT.WiLBiTGradientPanel();
            btnManageRoom = new WiLBiT.WiLBiTButton();
            lblOwner = new Label();
            lblRoomName = new Label();
            picRoom = new PictureBox();

            this.panRoom.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(169)))));
            this.panRoom.BackColor2 = Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(190)))));
            this.panRoom.BorderColor = Color.Peru;
            this.panRoom.BorderRadius = 15;
            this.panRoom.BorderSize = 2;
            this.panRoom.Controls.Add(this.btnManageRoom);
            this.panRoom.Controls.Add(this.lblOwner);
            this.panRoom.Controls.Add(this.lblRoomName);
            this.panRoom.Controls.Add(this.picRoom);
            this.panRoom.ForeColor = Color.Peru;
            this.panRoom.Location = new Point(10, 6);
            this.panRoom.Name = "panRoom"+countOfRooms;
            this.panRoom.Size = new Size(270, 285);
            this.panRoom.TabIndex = 4;

            this.btnManageRoom.BackColor = Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
            this.btnManageRoom.BorderColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnManageRoom.BorderRadius = 15;
            this.btnManageRoom.BorderSize = 2;
            this.btnManageRoom.FlatAppearance.BorderSize = 0;
            this.btnManageRoom.FlatStyle = FlatStyle.Flat;
            this.btnManageRoom.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.ForeColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(120)))));
            this.btnManageRoom.Location = new Point(12, 189);
            this.btnManageRoom.Name = "lblManageRoom" + countOfRooms;
            this.btnManageRoom.Size = new Size(90, 80);
            this.btnManageRoom.TabIndex = 5;
            this.btnManageRoom.Text = "Manage";
            this.btnManageRoom.UseVisualStyleBackColor = false;

            this.lblOwner.AutoSize = true;
            this.lblOwner.BackColor = Color.Transparent;
            this.lblOwner.Font = new Font("B Koodak", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(178)));
            this.lblOwner.Location = new Point(177, 233);
            this.lblOwner.Name = "lblOwner" + countOfRooms;
            this.lblOwner.Size = new Size(78, 36);
            this.lblOwner.TabIndex = 4;
            this.lblOwner.Text = "اتاقِ"+userName;

            this.picRoom.BackColor = Color.Silver;
            this.picRoom.BackgroundImageLayout = ImageLayout.Stretch;
            this.picRoom.Dock = DockStyle.Top;
            this.picRoom.Location = new Point(0, 0);
            this.picRoom.Name = "picRoom" + countOfRooms;
            this.picRoom.Size = new Size(270, 182);
            this.picRoom.TabIndex = 1;
            this.picRoom.TabStop = false;
        }
    }
}
