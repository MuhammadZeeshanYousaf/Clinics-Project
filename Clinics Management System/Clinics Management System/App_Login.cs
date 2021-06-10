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

        //Function that log in Receptionist
        private void loginReceptionist(string username, string password)
        {
            //Open the database connection
            connection.Open();
            //make query
            String query = "SELECT rec_id, password, rec_name FROM Receptionist WHERE rec_id=\'" + username + "\';";
            //pass query to SqlCommand
            cmd = new SqlCommand(query, connection);
            //Execute the query
            dataReader = cmd.ExecuteReader();
            //Read the result of that query
            bool IsRead = dataReader.Read();
            //if result for the query exist then proceed log in
            if (IsRead)
            {
                //read columns in format (column 0, column 1, column 2)
                string result_userName = dataReader[0].ToString();
                string result_password = dataReader[1].ToString();
                string result_receptionist_name = dataReader[2].ToString();

                //Close the connection completely
                dataReader.Close();
                connection.Close();
                //if password match then log in that receptionist
                if (password == result_password)
                {
                    //Here user successfully loged in
                    //MessageBox.Show(" \"" + result_receptionist_name + " \" Log in Successfull.");
                    this.Visible = false;
                    new Receptionist(result_receptionist_name, connection).Show();
                    
                    /*
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Receptionist(result_receptionist_name));
                    */
                }
                else
                    MessageBox.Show("Password is Incorrect!");
            }
            else
                MessageBox.Show("Username / ID is Incorrect!");
            //Close the connection completely
            dataReader.Close();
            connection.Close();
        }

        //Function that log in doctor
        private void loginDoctor(string username, string password)
        {
            //Open the database connection
            connection.Open();
            //make query
            String query = "SELECT doctor_id, password, doctor_name FROM Doctors WHERE doctor_id=\'" + username + "\';";
            //pass query to SqlCommand
            cmd = new SqlCommand(query, connection);
            //Execute the query
            dataReader = cmd.ExecuteReader();
            //Read the result of that query
            bool IsRead = dataReader.Read();
            //if result for the query exist then proceed log in
            if (IsRead)
            {
                //read columns in format (column 0, column 1, column 2)
                string result_userName = dataReader[0].ToString();
                string result_password = dataReader[1].ToString();
                string result_doctor_name = dataReader[2].ToString();

                dataReader.Close();
                connection.Close();
                //if password match then log in that DOCTOR
                if (password == result_password)
                {
                    //Here user successfully loged in
                    //MessageBox.Show("\" "+result_doctor_name+" \" Log in Successfull.");
                    this.Visible = false;
                    new Doctor(result_userName ,result_doctor_name, connection).Show();
                }
                else
                    MessageBox.Show("Password is Incorrect!");
            }
            else
                MessageBox.Show("Username / ID is Incorrect!");
            //Close the connection
            dataReader.Close();
            connection.Close();
        }


        //FileInfo file = new FileInfo("C:\\myscript.sql");
        //string script = file.OpenText().ReadToEnd();


        //Event on Log In button clicked
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
            else
            {
                MessageBox.Show("Choose the Role to login!");
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
