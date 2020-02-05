using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
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
            //Initialize the tadabase connections.
            //Now that it's initialized, everybody can use this global information.
            GlobalConfig.InitializeConnetcions(DatabaseType.Sql);
            //Application.Run(new TournamentDashboardForm()); // When this form is closed, the application will close even if there are other forms open.
            Application.Run(new TournamentDashboardForm());

  
        }
    }

    static class Teste
    {
        public static int TesteProp { get; set; }

        public static void TesteMetodo()
        {

        }
    }
}
