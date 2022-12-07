using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            {
                // TODO - Set up the SQL Connector
               sqlConnector sql = new sqlConnector();
                Connections.Add(sql);
            }

            if (textfiles)
            {
                // TODO - create the text Connection  
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
