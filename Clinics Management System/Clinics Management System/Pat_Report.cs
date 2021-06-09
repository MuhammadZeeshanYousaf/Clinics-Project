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
            string pat_name;
            string pat_health_problem;
            string total_appointments;
            //print the name in output label
            //pat_nameShow_label.Text = pat_name;
            //ProblemShow_label.Text = pat_health_problem;
            //appointShow_label.Text = total_appointments;
            //loop
            //app_doctors_lstbox.Items.Add();
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
