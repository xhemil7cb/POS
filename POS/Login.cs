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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // On Click Check for Username and Passsword then send to server


            await Call_Networking_LoginAsync();
        }

        private async Task Call_Networking_LoginAsync()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            await Networking.Login(username, password);
        }
        
    }
}
