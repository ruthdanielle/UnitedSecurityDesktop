using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UnitedSecurity
{
    public class Conexao
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial CAtalog = DB_UnitedSecurity; Integrated Security = True");
            return cnn;
        }

        // Nome do servidor: (LocalDB)\MSSQLLocalDB
        // Nome do banco: DB_UnitedSecurity
    }
}
