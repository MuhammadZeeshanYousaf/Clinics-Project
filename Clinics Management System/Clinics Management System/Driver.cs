using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clinics_Management_System
{
    static class Driver
    {
        //Local Database connection
        //static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\My Git repositories\Clinics-Project\Clinics Management System\Clinics Management System\ClinicsDatabase.mdf';Integrated Security=True;Connect Timeout = 30");
        
        //Azure database connection
        static readonly SqlConnection conn = new SqlConnection("Data Source=zee-server.database.windows.net;Initial Catalog=\"Clinics Database\";User ID=zeeadmin;Password=zee_admin123;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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
