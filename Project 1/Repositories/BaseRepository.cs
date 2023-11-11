using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Repositories
{
    public abstract class BaseRepository
    {
        protected string connectionString;
        //...
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
