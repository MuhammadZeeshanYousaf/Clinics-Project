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
    public partial class patient_history : Form
    {
        SqlConnection connection;
        string doctor_appointed;
        string pat_cnic;
        public patient_history(string doctor_id, string patient_nic, SqlConnection conn)
        {
            InitializeComponent();
            doctor_appointed = doctor_id;
            pat_cnic = patient_nic;
            connection = conn;

            //populate grid view for retrived patient history data
            Show_patientHistory();
        }

        void Show_patientHistory()
        {
            //save query in Qeury variable
            string Query = String.Format("SELECT * FROM One_pat_history('{0}','{1}');", doctor_appointed, pat_cnic);
            connection.Open();
            //make adapter connection 
            SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
            DataTable table_view = new DataTable();
            adapter.Fill(table_view);

            //pass the data adapter which has database function (One_pat_history(doctor_id)) view 
            pat_history_dataGridView.DataSource = table_view;
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
