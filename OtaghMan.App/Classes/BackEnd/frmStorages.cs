﻿using OtaghMan.Data.Context;
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
        public void CartGenerator(int countOfRooms, string roomName, string roomPic)
        {

            WiLBiT.WiLBiTPanel panStorage_ = new WiLBiT.WiLBiTPanel();
            WiLBiT.WiLBiTTextBox txtStorageType_ = new WiLBiT.WiLBiTTextBox();
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
            panStorage_.Name = "panStorage"+ countOfRooms;
            panStorage_.Size = new System.Drawing.Size(268, 121);
            panStorage_.TabIndex = 0;
            panStorage_.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panStorage_MouseClick);
            // 
            // txtStorageType
            // 
            txtStorageType_.BackColor = System.Drawing.Color.Bisque;
            txtStorageType_.BorderColor = System.Drawing.Color.Empty;
            txtStorageType_.BorderFocusColor = System.Drawing.Color.Empty;
            txtStorageType_.BorderRadius = 4;
            txtStorageType_.BorderSize = 2;
            txtStorageType_.Cursor = System.Windows.Forms.Cursors.Default;
            txtStorageType_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            txtStorageType_.ForeColor = System.Drawing.Color.Peru;
            txtStorageType_.Location = new System.Drawing.Point(89, 53);
            txtStorageType_.Margin = new System.Windows.Forms.Padding(4);
            txtStorageType_.Multiline = false;
            txtStorageType_.Name = "txtStorageType" + countOfRooms;
            txtStorageType_.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            txtStorageType_.PasswordChar = false;
            txtStorageType_.PlaceholderColor = System.Drawing.Color.DarkGray;
            txtStorageType_.PlaceholderText = "";
            txtStorageType_.Size = new System.Drawing.Size(175, 38);
            txtStorageType_.TabIndex = 1;
            txtStorageType_.Texts = "";
            txtStorageType_.UnderlinedStyle = false;
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
            txtStorageName_.Name = "txtStorageName" + countOfRooms;
            txtStorageName_.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            txtStorageName_.PasswordChar = false;
            txtStorageName_.PlaceholderColor = System.Drawing.Color.DarkGray;
            txtStorageName_.PlaceholderText = "";
            txtStorageName_.Size = new System.Drawing.Size(175, 38);
            txtStorageName_.TabIndex = 0;
            txtStorageName_.Texts = "";
            txtStorageName_.UnderlinedStyle = false;
            // 
            // splitBetween
            // 
            splitBetween_.Dock = System.Windows.Forms.DockStyle.Top;
            splitBetween_.Enabled = false;
            splitBetween_.Location = new System.Drawing.Point(0, 121);
            splitBetween_.Name = "splitBetween" + countOfRooms;
            splitBetween_.Size = new System.Drawing.Size(268, 10);
            splitBetween_.TabIndex = 4;
            splitBetween_.TabStop = false;
        }

        public void CartCaller()
        {
            //panContaneStorage.Controls.Clear();
            //db = new RoomsUnit();
            //foreach (var cart in db.RoomsRepository.GetAllRooms())
            //{
            //    CartGenerator(cart.ROOM_ID, cart.ROOM_NAME, cart.ROOM_PIC);

            //}
        }
    }
}