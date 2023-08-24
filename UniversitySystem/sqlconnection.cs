using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UniversitySystem
{
    class sqlconnection
    {
        public SqlConnection connection()
        {
            SqlConnection cont = new SqlConnection(@"Data Source=LAPTOP-NV4U1SKQ\SQLEXPRESS;Initial Catalog=UniversityAutomation;Integrated Security=True");
            cont.Open();
            return cont;
        }
    }
}
