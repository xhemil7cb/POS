using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();



            // If i have a vaild cookie I wanna skip typing username and password
            // Vazdo ktu Bone if bool true me thirr Formen Main.cs  <<<<<--------------------
            Task.Run(async () => await Networking.CheckCookieValidityAsync(Properties.Resources.Cookie));

            

        }



        private async void button1_Click(object sender, EventArgs e)
        {
            // On Click Check for Username and Passsword then send to server

            string username = textBox1.Text;
            string password = textBox2.Text;


            

            await Networking.Login(username, password);

        }

        
        
    }
}
