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
    public partial class Checked_pat : Form
    {
        string appointed_doctor;
        SqlConnection connection;

        public Checked_pat(string doctor_id, SqlConnection conn)
        {
            InitializeComponent();
            appointed_doctor = doctor_id;
            //get connection of local db
            connection = conn;
            //populate the data of patients history in dataSet view
            showGridView();
        }

        void showGridView()
        {
            connection.Open();
            string query = String.Format("SELECT * FROM All_pat_history('{0}');", appointed_doctor);
            //string query = "SELECT * FROM All_pat_history('"+appointed_doctor+"');";
            //generate query
            SqlCommand cmd = new SqlCommand(query ,connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table_view = new DataTable();
            adapter.Fill(table_view);
            
            //pass the data adapter which has database function (All_pat_history(doctor_id)) view 
            checked_pat_dataGrid.DataSource = table_view;
            connection.Close();
        }
        private void Checked_pat_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
