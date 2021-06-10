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
    public partial class Pat_Report : Form
    {
        //data members
        string patient_cnic;
        string patient_name;
        SqlConnection connection;
        //Constructor
        public Pat_Report(string pat_cnic, string pat_name, SqlConnection conn)
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

            //Show report of the patient when this form opened
            showReport();
        }

        //Function To show complete report after retreiving data from database
        void showReport()
        {
            //Run Query
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT health_problem, doctor_appointed FROM Patients_history WHERE patient_cnic = '"+patient_cnic+"';";
            SqlDataReader dataReader1 = cmd.ExecuteReader();
            if(dataReader1.HasRows)
            {
                while (dataReader1.Read())// till end of table
                {
                    health_problems_lstbox.Items.Add(dataReader1["health_problem"].ToString());
                    appoint_doctors_lstbox.Items.Add(dataReader1["doctor_appointed"].ToString());
                }
                dataReader1.Close();
            }
            else
            {
                MessageBox.Show("No History Exist for this patient!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataReader1.Close();
            }

            cmd.CommandText = "SELECT COUNT(patient_cnic) FROM Patients_history WHERE patient_cnic='" + patient_cnic + "';";
            SqlDataReader dataReader2 = cmd.ExecuteReader();
            dataReader2.Read();
            No_appointShow_label.Text = dataReader2[0].ToString();
            dataReader2.Close();
            connection.Close();
        }
        private void Pat_Report_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void inchargheading_lbl_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
