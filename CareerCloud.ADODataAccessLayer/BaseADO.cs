using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADO
    {
        private readonly string _connString;
        protected readonly SqlConnection _connection;
        public BaseADO()
        {
            _connString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            _connection = new SqlConnection( _connString);
        }

    }
}
