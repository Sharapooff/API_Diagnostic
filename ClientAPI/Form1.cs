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

using ClientAPI.Classes;
using Newtonsoft.Json;

namespace ClientAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string APP_PATH = "https://localhost:44364/";
        private static string token;

        private void login_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> tokenDictionary = Registering.GetTokenDictionary(LogInTextLogIn.Text, LogInTextPasword.Text, APP_PATH);
            token = tokenDictionary["access_token"];
            MessageBox.Show($"Access Token: {token}  | Пользователь: {Registering.GetUserInfo(token, APP_PATH)}  | Values: {Registering.GetValues(token, APP_PATH)}");
        }

        private void registration_Click(object sender, EventArgs e)
        {
            string userName = RegistrationTextLog.Text;
            string password = RegistrationTextPasword.Text;
            MessageBox.Show("Статусный код регистрации: {0}", Registering.Register(userName, password, APP_PATH));
        }



        
    }
}
