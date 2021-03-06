using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinics_Management_System
{
    public partial class Doctor : Form
    {
        string doctor_id;
        string DoctorName;
        SqlConnection connection;
        public Doctor(string dr_id, string doctorName, SqlConnection conn)
        {
            InitializeComponent();
            //populate data members for the specific doctor
            DoctorName = doctorName;
            Doctor_name_label.Text = DoctorName;
            connection = conn;
            doctor_id = dr_id;
        }

        private void unchecked_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void choices_lbl_Click(object sender, EventArgs e)
        {

        }

        private void MarkPat_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //make listboxes empty before updating values
            pat_cnic_listBox.Items.Clear();
            pat_name_listBox.Items.Clear();
            pat_healthProblem_listBox.Items.Clear();
            dr_appointed_listBox.Items.Clear();

            //make connection open
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            //Run Procedure named as Appointed_patients
            cmd.CommandText = "EXECUTE Appointed_patients @dr_id = '" + doctor_id + "';";
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                //read all values
                while (dataReader.Read())// till end of table
                {
                    pat_cnic_listBox.Items.Add(dataReader["patient_cnic"].ToString()); // read data from student column 0
                    pat_name_listBox.Items.Add(dataReader["patient_name"].ToString());// read data from student column 1
                    pat_healthProblem_listBox.Items.Add(dataReader["health_problem"].ToString());// read data from student column 2
                    dr_appointed_listBox.Items.Add(dataReader["doctor_appointed"].ToString());// read data from student column 3
                }
                dataReader.Close();
                connection.Close();
            }
            else
            {
                MessageBox.Show("No Appointments yet!");
                dataReader.Close();
                connection.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //get top value from list box
            string topPatient_cnic = pat_cnic_listBox.Items[0].ToString();
            string topPatient_healthProblem = pat_healthProblem_listBox.Items[0].ToString();
            string topPatient_doctor = dr_appointed_listBox.Items[0].ToString();
            string topPatient_app_dateTime;

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT appointment_data_time FROM Appointments WHERE patient_cnic = '" + topPatient_cnic + "' ORDER BY appointment_data_time DESC;";
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                topPatient_app_dateTime = dataReader[0].ToString();
                dataReader.Close();

                //Now insert this data into Patients_history table
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandText = "INSERT INTO Patients_history VALUES('" + topPatient_cnic + "','" + topPatient_healthProblem + "','" + topPatient_doctor + "','" + topPatient_app_dateTime + "');";

                try
                {
                    cmd1.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }
            }
            else
            {
                dataReader.Close();
                connection.Close();
                return;
            }

            //Appointed_patients and delete top record
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "DELETE FROM Appointments WHERE patient_cnic = '" + topPatient_cnic + "';";

            try
            {
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Top patient Marked Check Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }

            connection.Close();

        }

        private void checked_pat_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void checked_pat_btn_Click_1(object sender, EventArgs e)
        {
            new Checked_pat(doctor_id, connection).Show();
        }

        private void ViewRprt_btn_Click(object sender, EventArgs e)
        {
            //get patient cnic
            string pat_cnic = cnic_txtbox.Text;
            //check pat_cnic null or have value
            if (pat_cnic == null)
                return;
            //else show patient history in new Win form
            new patient_history(doctor_id, pat_cnic, connection).Show();
        }
    }
}
