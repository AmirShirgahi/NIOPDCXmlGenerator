using NIOPDCXmlGenerator.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NIOPDCXmlGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm(null));
            //Application.Run(new PatientVisitFrm());
            //Application.Run(new InsertPatientFrm(null));



            //using var login = new LoginFrm();
            //var dr = login.ShowDialog();
            //if (dr == DialogResult.OK && login.AuthenticatedUser != null)
            //{
            //    Application.Run(new MainFrm(login.AuthenticatedUser));
            //}
        }
    }
}