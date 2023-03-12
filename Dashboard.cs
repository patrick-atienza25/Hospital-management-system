using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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

            newPatientPanel.Visible = false;
            diagnosisPanel.Visible = false;
            fullHistoryPanel.Visible = true;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-U5ATJLU\\SQLEXPRESS; database = hospital; integrated security = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM addpatient INNER JOIN PatientDiagnosis ON addpatient.Pid = PatientDiagnosis.PID";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indicator1.ForeColor = System.Drawing.Color.Black;
            indicator2.ForeColor = System.Drawing.Color.Red;
            indicator3.ForeColor = System.Drawing.Color.Black;
            newPatientPanel.Visible = false;
            diagnosisPanel.Visible = true;
            fullHistoryPanel.Visible = false;
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
            diagnosisPanel.Visible = false;
            fullHistoryPanel.Visible = false;
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
            diagnosisPanel.Visible = false;
            fullHistoryPanel.Visible = false;
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
                String pid = txtPid.Text;
                String name = txtName.Text;
                String address = txtAddress.Text;
                String contact = txtEmergency.Text;
                String phoneNumber = txtPhoneNumber.Text;
                String age = txtAge.Text;
                String gender = txtGender.Text;
                String bloodType = txtBloodType.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source =DESKTOP-U5ATJLU\\SQLEXPRESS; database = hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into addpatient values (" + pid + " ,'" + name + "' , '" + address + "' , '" + contact + "' , " + phoneNumber + ", " + age + ",'" + gender + "','" + bloodType + "');";

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
            }
            catch (Exception)
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

        public class SpecialException : ApplicationException
        {
            public SpecialException() { }
            public SpecialException(string message) : base(message) { }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if(txtPIDDiagnosisPanel.Text != null)
                {
                    int PID = Convert.ToInt32(txtPIDDiagnosisPanel.Text);

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "data source =DESKTOP-U5ATJLU\\SQLEXPRESS; database = hospital; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM addpatient WHERE pid = " + PID + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch(Exception)
            {
                if(txtPIDDiagnosisPanel == null)
                {
                    throw new Exception();
                }
            }
        }

        private void PID_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void diagnosisPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPIDDiagnosisPanel.Text != null)
                {
                    String pid = txtPIDDiagnosisPanel.Text;
                    String symptoms = txtBoxSymptoms.Text;
                    String diagnosis = txtBoxDiagnosis.Text;
                    String medications = txtBoxMedications.Text;
                    String wardRequired = comboBoxWardRequired.Text;
                    String wardType = comboBoxWardType.Text;

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "data source =DESKTOP-U5ATJLU\\SQLEXPRESS; database = hospital; integrated security = True";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT into PatientDiagnosis values (" + pid + ", '" + symptoms + "', '" + diagnosis + "', '" + medications + "', '" + wardRequired + "', '" + wardType + "');";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    MessageBox.Show("Data Saved");

                    txtPIDDiagnosisPanel.Clear();
                    txtBoxSymptoms.Clear();
                    txtBoxDiagnosis.Clear();
                    txtBoxMedications.Clear();
                    comboBoxWardRequired.ResetText();
                    comboBoxWardType.ResetText();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Field(s) are empty or data is in wrong format. Please try again");
            }
        }

        private void comboBoxWardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void indicator1_Click(object sender, EventArgs e)
        {

        }

        private void indicator3_Click(object sender, EventArgs e)
        {

        }
    }
}
