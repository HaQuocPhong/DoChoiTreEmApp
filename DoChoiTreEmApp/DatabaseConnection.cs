using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoChoiTreEmApp
{
    class DatabaseConnection
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-37L9F7U;Initial Catalog=dochoitreemapp;Integrated Security=True");
    }
}
