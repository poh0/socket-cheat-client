using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Networking;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZBase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = emailTextBox;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
                return;

            var values = new Dictionary<string, string>()
            {
                { "email", email },
                { "password", password }
            };

            var content = new FormUrlEncodedContent(values);
            var response = await Network.client.PostAsync(Network.API_URL + "/api/users/authenticate", content);
            var responseString = await response.Content.ReadAsStringAsync();

            JObject responseObj = JObject.Parse(responseString);

            if ((bool)responseObj["success"])
            {
                // Move to next form
                Network.token = (string)responseObj["token"];
                Menu mainMenu = new Menu();
                mainMenu.Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Failed to login", "Error", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
