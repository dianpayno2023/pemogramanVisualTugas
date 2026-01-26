using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username tidak boleh kosong");


            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password tidak boleh kosong");
            }
            if (username == "admin" && password == "admin123")
            {
                Homepage mainmenu = new Homepage();
                mainmenu.Show();

                this.Hide();
            }
            else
            {
                textUsername.Clear();   
                textPassword.Clear();   
                textUsername.Focus();
                MessageBox.Show("Invalid Credentials");
            }
               

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
