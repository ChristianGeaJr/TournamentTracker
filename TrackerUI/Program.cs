using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
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

            RegistrySettings();

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\TournamentTracker");
            bool dataConnectionExists = key.GetValueNames().Contains("DataConnection");

            DatabaseType databaseType = 0;

            if (dataConnectionExists == true)
            {
                if (key.GetValue("DataConnection").Equals("TextFile"))
                {
                    databaseType = DatabaseType.TextFile;
                    ConfigurationManager.AppSettings["filePath"] = key.GetValue("FilePath").ToString();
                }
                else if (key.GetValue("DataConnection").Equals("SQL"))
                {
                    //ConnectionStringSettings connectionString = new ConnectionStringSettings();
                    //connectionString.ConnectionString = key.GetValue("DataConnection").ToString();
                    //connectionString.Name = "Tournaments";
                    //connectionString.ProviderName = "System.Data.SqlClient";
                    //ConfigurationManager.ConnectionStrings.Add(connectionString);
                    databaseType = DatabaseType.Sql;
                }


                GlobalConfig.InitializeConnetcions(databaseType);

                //Initialize the tadabase connections.
                //Now that it's initialized, everybody can use this global information.
                // When this form is closed, the application will close even if there are other forms open.
                Application.Run(new TournamentDashboardForm());
            }
            key.Close();

         }

        private static void RegistrySettings()
        {
            //Registry

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TournamentTracker");

            RegistryKey checkRegistry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\TournamentTracker");
            bool dataConnectionExists = key.GetValueNames().Contains("DataConnection");

            if (dataConnectionExists == false)
            {

                Application.Run(new InitialSettingsForm());

            }

            key.Close();
            checkRegistry.Close();
        }
    }

}
