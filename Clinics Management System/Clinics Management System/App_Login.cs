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
    public partial class App_Login : Form
    {
        //Data members to get database connections and instances
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader dataReader;

        //Constructor
        public App_Login(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void loginReceptionist(string username, string password)
        {

            if (username == "pat" && password == "pass")
                Console.WriteLine("Receptionist Loged in");
        }

        public void loginDoctor(string username, string password)
        {
            connection.Open();
            String query = "SELECT doctor_id, password, doctor_name FROM Doctors WHERE doctor_id=\'" + username + "\';";
            cmd = new SqlCommand(query, connection);
            dataReader = cmd.ExecuteReader();
            bool IsRead = dataReader.Read();
            if (IsRead)
            {
                string result_userName = dataReader[0].ToString();
                string result_password = dataReader[1].ToString();
                string result_doctor_name = dataReader[2].ToString();

                if (username == result_userName)
                {
                    if (password == result_password)
                    {
                        MessageBox.Show("\""+result_doctor_name+"\" Log in Successfull.");
                    }
                    else
                        MessageBox.Show("Password is Incorrect!");
                }
                else
                    MessageBox.Show("Username is Incorrect!");
            }
            else
                MessageBox.Show("User does not exist!");
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;

            if (IsDoctor.Checked)
            {
                loginDoctor(username, password);

            }
            else if(IsReceptionist.Checked)
            {
                loginReceptionist(username, password);
            }

        }

        private void App_Login_Load(object sender, EventArgs e)
        {

        }

        private void IsDoctor_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void IsReceptionist_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
