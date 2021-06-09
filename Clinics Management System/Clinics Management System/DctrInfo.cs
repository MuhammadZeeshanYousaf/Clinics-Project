using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinics_Management_System
{
    public partial class DctrInfo : Form
    {
        public DctrInfo(string dr_name, string spec ,string dr_age, string room, string spec_details)
        {
            InitializeComponent();

            //show all doctor information to the output form labels
            dr_name_label.Text = dr_name;
            dr_spec_label.Text = spec;
            dr_age_label.Text = dr_age;
            dr_room_label.Text = room;
            spec_details_label.Text = spec_details;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DctrInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
