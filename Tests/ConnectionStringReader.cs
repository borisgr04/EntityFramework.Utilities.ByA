using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ServiceStack.Text;

namespace Tests
{
    public static class ConnectionStringReader
    {
        private static ConnectionStrings connectionsStrings;

        public static ConnectionStrings ConnectionStrings
        {
            get
            {
                if(connectionsStrings == null){
                    using(var stream = File.OpenRead("connectionStrings.json")){
                        connectionsStrings = JsonSerializer.DeserializeFromStream<ConnectionStrings>(stream);
                        //connectionsStrings.SqlServer=connectionsStrings.SqlServer.Replace("SqlExpress", @".\SqlExpress");
                    }
                }
                return connectionsStrings;
            }
        }

    }
}
