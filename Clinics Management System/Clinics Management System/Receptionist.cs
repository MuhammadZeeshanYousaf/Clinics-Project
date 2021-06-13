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
    public partial class Receptionist : Form
    {
        string ReceptionistName;
        SqlConnection connection;

        //constructor
        public Receptionist(string Rec_Name, SqlConnection conn)
        {
            InitializeComponent();
            ReceptionistName = Rec_Name;
            Recetionist_name_label.Text = ReceptionistName;
            connection = conn;
        }

        //variable to be used by many fuctions
        private string patient_cnic;
        //Function To validate, is patient registered or not, if registered return name of the patient
        private string validatePatientReg()
        {
            //get patient cnic from text box
            patient_cnic = CNIC_txtbox.Text;
            //open the connection
            connection.Open();
            //make query
            String query = "SELECT patient_name FROM patients WHERE patient_cnic='" + patient_cnic + "';";
            //pass query to SqlCommand
            SqlCommand cmd = new SqlCommand(query, connection);
            //Execute the query
            SqlDataReader dataReader = cmd.ExecuteReader();
            //Read the result of that query
            bool IsRead = dataReader.Read();
            //if result for the query retured somthing then proceed to return name of the patient
            if (IsRead)
            {
                //read columns in format (column 0, column 1, column 2, ....)
                string result_patientName = dataReader[0].ToString();
                connection.Close();
                return result_patientName;
            }
            else
            {
                MessageBox.Show("Patient is not Registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return null;
            }
        }

        private void Dashboard_tab_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegPat_btn_Click(object sender, EventArgs e)
        {
            string pat_cnic = CNIC_txtbox.Text;

            if (pat_cnic == null)
                MessageBox.Show("Enter Patient CNIC");
            else
                new Pat_Registr(pat_cnic, connection).Show();
        }

        private void PatCNIC_lbl_Click(object sender, EventArgs e)
        {

        }

        //Doctor info button clicked
        private void button2_Click(object sender, EventArgs e)
        {
            string specialization = Spec_combobox.Text;
            if(specialization != null)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT doctor_name, doctor_age, doctor_room, specialization_details FROM Doctors WHERE specialization = '"+specialization+"';";
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if(dataReader.HasRows)
                {
                    string doctor_name = dataReader[0].ToString();
                    string doctor_age = dataReader[1].ToString();
                    string doctor_room = dataReader[2].ToString();
                    string doctor_details = dataReader[3].ToString();

                    dataReader.Close();
                    connection.Close();
                    new DctrInfo(doctor_name, specialization, doctor_age, doctor_room, doctor_details).Show();
                }
                else
                {
                    MessageBox.Show("Doctor does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataReader.Close();
                    connection.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Enter Doctor Specialization!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void patients_manage_Click(object sender, EventArgs e)
        {

        }

        private void Dctr_btn_Click(object sender, EventArgs e)
        {
            string validation_result_patientName = validatePatientReg();
            if (validation_result_patientName != null)
            {
                new DctrAppoint(patient_cnic, validation_result_patientName, connection).Show();
            }
        }

        private void ViewRprt_btn_Click(object sender, EventArgs e)
        {
            string validation_result_patientName = validatePatientReg();
            if (validation_result_patientName != null)
            {
                new Pat_Report(patient_cnic, validation_result_patientName, connection).Show();
            }
        }

        private void Spcls_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoomNo_lbl_Click(object sender, EventArgs e)
        {

        }

        private void RoomNo_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StsInfo_btn_Click(object sender, EventArgs e)
        {
            string roomNo = RoomNo_txtbox_c.Text;
            if (roomNo == null)
                return;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT doctor_name, specialization FROM Doctors WHERE doctor_room = " + int.Parse(roomNo.ToString()) + ";";
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            if(dataReader.HasRows)
            {
                string doctor_name = dataReader[0].ToString();
                string specialization = dataReader[1].ToString();
                dataReader.Close();
                connection.Close();
                new Room_Stat_Info(roomNo, doctor_name, specialization).Show();
            }
            else
            {
                MessageBox.Show("Room does not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
                connection.Close();
            }
        }

        private void Room_tab_Click(object sender, EventArgs e)
        {

        }
    }
}
