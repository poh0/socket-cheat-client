﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Cheats;
using ZBase.Classes;
using ZBase.Networking;
using ZBase.Utilities;
using SocketIOClient;
using Newtonsoft.Json;

namespace ZBase
{
    public partial class Menu : Form
    {

        SocketIO client;

        public Menu()
        {
            InitializeComponent();
            if (Main.RunStartup())
            {
                OffsetUpdater.UpdateOffsets();
                #region Start Threads

                Tools.InitializeGlobals();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Bunnyhop.Run();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Visuals v = new Visuals();
                    v.Run();
                }).Start();
                #endregion
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
#if DEBUG
            TopMost = true;
#else
            TopMost = false;
#endif

            client = new SocketIO(Sockets.API_URL);

            client.On("getOptions", UpdateSettings);
            client.OnConnected += OnClientConnected;
            client.OnDisconnected += OnClientDisconnected;

            client.ConnectAsync();
        }

        public void UpdateSettings(SocketIOResponse response)
        {
            string jsonresp = response.GetValue().ToString();

            var dto = JsonConvert.DeserializeObject<Settings>(jsonresp);

            Main.S = dto;

            UpdateMenu();
        }

        public void UpdateMenu()
        {
            Invoke((MethodInvoker)delegate
            {
                ESPCheck.Checked = Main.S.ESP;
                BunnyhopCheck.Checked = Main.S.BunnyhopEnabled;
                boxesp_checkbox.Checked = Main.S.box_esp;
                healthbar_checkbox.Checked = Main.S.healthbar_esp;
                snaplines_checkbox.Checked = Main.S.snaplines;
            });
        }

        public async void OnClientConnected(object sender, EventArgs e)
        {
            statusLabel.Invoke((MethodInvoker)delegate
            {
                statusLabel.Text = "Connected";
                statusLabel.ForeColor = Color.Green;
            });
            await client.EmitAsync("addClient", Sockets.USER);
        }

        public void OnClientDisconnected(object sender, string reason)
        {
            statusLabel.Invoke((MethodInvoker)delegate
            {
                statusLabel.Text = "Disconnected";
                statusLabel.ForeColor = Color.Red;
            });
        }

        private void ZbaseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Coopyy/ZBase-CSGO");
        }

        private void ESPCheck_CheckedChanged(object sender, EventArgs e)
        {
            Main.S.ESP = ESPCheck.Checked;
        }

        private void BunnyhopCheck_CheckedChanged(object sender, EventArgs e)
        {
            Main.S.BunnyhopEnabled = BunnyhopCheck.Checked;
        }

        private void boxesp_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Main.S.box_esp = boxesp_checkbox.Checked;
        }

        private void healthbar_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Main.S.healthbar_esp = healthbar_checkbox.Checked;
        }

        private void snaplines_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Main.S.snaplines = snaplines_checkbox.Checked;
        }
    }
}
