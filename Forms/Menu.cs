﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Cheats;
using ZBase.Utilities;

namespace ZBase
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Main.RunStartup())
            {
                OffsetUpdater.UpdateOffsets();
                #region Start Threads
                // found the process and everything, lets start our cheats in a new thread
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    CheckMenu();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Tools.InitializeGlobals();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Bunnyhop.Run();
                }).Start();

                Visuals v = new Visuals();
                #endregion
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            TopMost = true; // make this hover over the game, can remove if you want
        }

        public void CheckMenu()
        {
            // Here we make the main variables equal to what our menu checkboxes say
            while (true)
            {
                Main.S.BunnyhopEnabled = BunnyhopCheck.Checked;
                Main.S.ESP = ESPCheck.Checked;
                if ((Memory.GetAsyncKeyState(Keys.VK_INSERT) & 1) > 0)
                    Visible = !Visible;

                Thread.Sleep(1); // Greatly reduces cpu usage
            }
        }

        private void DiscordBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/cFmAYvm");
        }

        private void GithubBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Coopyy/ZBase-CSGO");
        }
    }
}
