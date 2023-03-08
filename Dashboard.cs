using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            indicator1.ForeColor = System.Drawing.Color.Black;
            indicator2.ForeColor = System.Drawing.Color.Black;
            indicator3.ForeColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indicator1.ForeColor = System.Drawing.Color.Black;
            indicator2.ForeColor = System.Drawing.Color.Red;
            indicator3.ForeColor = System.Drawing.Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            indicator1.ForeColor = System.Drawing.Color.Red;
            indicator2.ForeColor = System.Drawing.Color.Black;
            indicator3.ForeColor = System.Drawing.Color.Black;

            newPatientPanel.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            newPatientPanel.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(txtPid.Text);
                String name = txtName.Text;
                String address = txtAddress.Text;
                String contact = txtEmergency.Text;
                int phoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = txtGender.Text;
                String bloodType = txtBloodType.Text;
                String symptoms = txtExperienced.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-U5ATJLU\\SQLEXPRESS; database = hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into addpatient values (" + pid + " ,'" + name + "' , '" + address + "' , '" + contact + "' , " + phoneNumber + ", " + age + ",'" + gender + "','" + bloodType + "','" + symptoms + "');";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Information saved!");

                txtPid.Clear();
                txtName.Clear();
                txtAddress.Clear();
                txtEmergency.Clear();
                txtPhoneNumber.Clear();
                txtAge.Clear();
                txtGender.Clear();
                txtBloodType.Clear();
                txtExperienced.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("Error has occurred. Please try again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
