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
    public partial class Doctor : Form
    {
        string DoctorName;
        SqlConnection connection;
        public Doctor(string doctorName, SqlConnection conn)
        {
            InitializeComponent();
            DoctorName = doctorName;
            Doctor_name_label.Text = DoctorName;
            connection = conn;
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
    }
}
