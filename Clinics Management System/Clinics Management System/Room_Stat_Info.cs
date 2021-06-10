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
    public partial class Room_Stat_Info : Form
    {
        public Room_Stat_Info(string room, string doctor_name, string spec)
        {
            InitializeComponent();
            room_no_txtbox.Text = room;
            dr_name_txtbox.Text = doctor_name;
            spec_txtbox.Text = spec;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Room_Stat_Info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
