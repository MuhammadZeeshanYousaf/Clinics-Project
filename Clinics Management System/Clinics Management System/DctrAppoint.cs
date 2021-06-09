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
    public partial class DctrAppoint : Form
    {
        string patient_cnic;
        string patient_name;
        SqlConnection connection;

        //constructor
        public DctrAppoint(string pat_cnic, string pat_name, SqlConnection conn)
        {
            InitializeComponent();
            //set connection variable
            connection = conn;
            //show patient cnic to the output label
            patient_cnic = pat_cnic;
            CNIC_show_label.Text = patient_cnic;
            //show patient name to the output label
            patient_name = pat_name;
            pat_nameShow_label.Text = patient_name;
        }

        private void DctrAppoint_Load(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string health_problem = healthProb_txtbox.Text;
            string doctor_specializtion = doctor_spec_combobox.Text;

            if (health_problem == null || doctor_specializtion == null)
                return;

            //insert data into appointments table----------------------

            //Get Doctor id
            string doctor_id = get_DoctorId(doctor_specializtion);
            //if doctor id found then insert data into appointments table
            if(doctor_id != null)
            {
                connection.Open();
                //create command for Sql query
                SqlCommand cmd = connection.CreateCommand();
                //make query for insertion into Appointments table
                cmd.CommandText = "INSERT INTO Appointments (appointment_data_time, patient_cnic, health_problem, doctor_appointed, treatment_status) VALUES ( SYSDATETIME(), '"+patient_cnic+"', '"+health_problem+"', '"+doctor_id+"', 'Pending')";

                //Now execute qeury by handling exception
                try
                {
                    cmd.ExecuteNonQuery();  //Execute query
                    DialogResult res = MessageBox.Show("Patient Appointed! Now wait for your turn.");
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

        }

        //Function to retrieve doctor_id from Doctors table
        private string get_DoctorId(string dr_specialization)
        {
            //open the connection
            connection.Open();
            //make query
            String query = "SELECT doctor_id FROM Doctors WHERE specialization=\'" + dr_specialization + "\';";
            //pass query to SqlCommand
            SqlCommand cmd = new SqlCommand(query, connection);
            //Execute the query
            SqlDataReader dataReader = cmd.ExecuteReader();
            //Read the result of that query
            bool IsRead = dataReader.Read();
            if(IsRead)
            {
                string doctor_id = dataReader[0].ToString();
                dataReader.Close();
                connection.Close();
                return doctor_id;
            }
            else
            {
                MessageBox.Show("Doctor you have selected not found!");
                dataReader.Close();
                connection.Close();
                return null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PnameShow_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
