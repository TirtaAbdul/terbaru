using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManPowerSystem.Classes
{
    internal class Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = null;
            try
            {
                string cons = "Data Source=IS-INTERN02;Initial Catalog=ProjectHR-02;Persist Security Info=True;User ID=tah";
                conn = new SqlConnection(cons);
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return conn;
        }
    }
}
