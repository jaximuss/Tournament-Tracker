using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAcess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// THIS IS JUST A LIST OF DATA STRUCTURES??? WHERE U TECHINCALLY WANT TO STORE YOUR DATA LIKE SQL, TEXTFILES , MYSQL OR MONGODB THINGS LIKE THAT.
        /// 
        /// //EDIT THIS HAS BEEN CHANGED SO AS TO ONLY ALLOW ONE DATA CONNECTION AT A TIME TO A STORAGE(WE ARE REMOVING THE LIST)
        /// </summary>
        public static IDataConnection connections { get; private set; }

        /// <summary>
        /// collects the data from either the sqlconnector or the textconnector and intializes either of them 
        /// then add the initializtion to the list of data connections
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textfiles"></param>
        public static void IntializeConnections(string connectionType)
        {
            if (connectionType == "sql")
            {
                SQLConnector sql  = new SQLConnector();
                connections = sql ;
            }
            else if (connectiontype == "textfile")
            {
                textconnector textfile = new textconnector();
                connections = textfile;

            }
        } 
        
er            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
