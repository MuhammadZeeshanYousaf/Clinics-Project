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

namespace Clinics_Management_System
{
    public partial class Pat_Registr : Form
    {
        //data members
        string patient_cnic;
        SqlConnection connection; // = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\ClinicsDatabase.mdf\";Integrated Security=True");

        //Constructor
        public Pat_Registr(string cnic, SqlConnection conn)
        {
            InitializeComponent();
            patient_cnic = cnic;
            cninc_show_label.Text = patient_cnic;
            connection = conn;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Pat_Registr_Load(object sender, EventArgs e)
        {

        }

        private void Reg_btn_Click(object sender, EventArgs e)
        {
            //get registeration credentials from text boxes
            string patient_name = pat_name_txtbox.Text;
            int patient_age = int.Parse(pat_age_txtbox.Text.ToString());
            string pat_gender = pat_gender_comboBox.Text;

            if (patient_name == null || patient_age == 0 || pat_gender == null)
                return;
            //make insert Query
            //string insert_query = "INSERT INTO patients VALUES("+patient_cnic+",\'"+patient_name+"\',"+patient_age+",\'"+pat_gender+"\');";
            //string insert_query = "INSERT INTO patients VALUES(@patient_cnic, \'@patient_name\', @patient_age, \'@pat_gender\');";

            //Open connection
            connection.Open();
            //pass query and connection to the SqlCommand to Execute
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO patients VALUES ('" + patient_cnic + "', '" + patient_name + "', '" + patient_age + "', '" + pat_gender + "');";

            //cmd.CommandText = "INSERT INTO patients VALUES(@patient_cnic, @patient_name, @patient_age, @pat_gender)";
            /*
            cmd.Parameters.AddWithValue("@patient_cnic", patient_cnic);
            cmd.Parameters.AddWithValue("@patient_name", patient_name);
            cmd.Parameters.AddWithValue("@patient_age", patient_age);
            cmd.Parameters.AddWithValue("@pat_gender", pat_gender);
            */

            try
            {
                //Execute query
                cmd.ExecuteNonQuery();
                DialogResult res = MessageBox.Show("Patient Successfully Registered!");
                connection.Close();
                if (res == DialogResult.OK)
                    this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
