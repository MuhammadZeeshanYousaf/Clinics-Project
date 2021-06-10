using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinics_Management_System
{
    static class Driver
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\My Git repositories\Clinics-Project\Clinics Management System\Clinics Management System\ClinicsDatabase.mdf';Integrated Security=True;Connect Timeout = 30");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            //main driver of the program

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App_Login(conn));
        }

    }
}
