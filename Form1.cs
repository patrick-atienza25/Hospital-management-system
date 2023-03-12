using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if(username == "pat" && password == "asdf")
            {
                //MessageBox.Show("You have entered correctly");

                this.Hide();

                Dashboard ds= new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
