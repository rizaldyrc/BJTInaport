using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace InaportClientBJTI.Helper
{
    class DBTPKDHelper
    {
        private DbConnection connection;
        public DbConnection Connection
        {
          get { return connection; }
          set { connection = value; }
        }

        private DbProviderFactory factory;
        public DbProviderFactory Factory
        {
            get { return factory; }
            set { factory = value; }
        }

        
        public void establishConnection()
        {
            Factory = DbProviderFactories.GetFactory("System.Data.OracleClient");
            Connection = Factory.CreateConnection();
            //Connection.ConnectionString = "Data Source=192.168.0.253:1521/orcl;User ID=tpkd;Password=tpkd;Unicode=True";
            Connection.ConnectionString = "Data Source=localhost:1521/orcl;User ID=aura;Password=4ur4;Unicode=True";
            Connection.Open();
        }

        public void releaseConnection()
        {
            Connection.Close();
        }
    }
}
