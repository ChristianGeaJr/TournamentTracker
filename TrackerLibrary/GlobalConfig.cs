using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig // You can't instantiante GlobalConfig. It's always visible for everyone
    {

        public const string PrizesFile = "PrizeModels.csv"; // The notation for constants is using the initial letter as uppercase.
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv"; // The pattern was not followed 
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchUpEntryFile = "MatchUpEntryModels.csv";

        //public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>(); //Previously it was a List<>
        public static IDataConnection Connection { get; private set; }

        //public static void InitializeConnetcions(bool sql, bool textFile)

        public static void InitializeConnetcions(DatabaseType db)
        {
            // Connections = new List<IDataConnection>(); => If we are using an old version of .NET Framework, the list must be initialized here
            //here we where we're going to initialize the connections.


            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {

                TextConnector text = new TextConnector();
                Connection = text;
            }

           
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookUp(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
