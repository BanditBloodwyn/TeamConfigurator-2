﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamConfigurator_2.Controls.Popups;
using TeamConfigurator_2.Services;
using TeamConfigurator_2.Classes;

namespace TeamConfigurator_2.Pages
{
    public partial class PlayerListPage : PageBase, IPage
    {
        public PlayerListPage()
        {
            InitializeComponent();
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void DeactivatePage()
        {
            base.DeactivatePage();
        }

        public override void ActivatePage()
        {
            base.ActivatePage();
        }

        private void UpdateList()
        {
            listView1.Items.Clear();

            foreach(Player oPlayer in DataService.Players.Values)
            {
                ListViewItem lviPlayer = new ListViewItem();
                lviPlayer.Tag = oPlayer;
                lviPlayer.Text = oPlayer.Name;
                lviPlayer.SubItems.Add(Convert.ToString(oPlayer.LPZ));

                listView1.Items.Add(lviPlayer);
            }
        }

        private void UpdatePage()
        {
            lbl_DateTime.Text = DataService.LoadDate + ", " + DataService.LoadTime;
        }

        private void btn_LoadFromTTLive_Click(object sender, EventArgs e)
        {
            //URLPopup oPopup = new URLPopup();
            //DataService.ExportKey = oPopup.StartDialog();

            DataService.LoadPlayersFromURL();
            UpdateList();
            UpdatePage();
        }
    }
}
