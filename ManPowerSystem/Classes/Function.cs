using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManPowerSystem.Classes
{
    class Function
    {
        public static string db_servername;
        public static string db_databasename;
        public static string db_userid;
        public static string db_password;
        public static SqlConnection db_con;
        //public static string App_SystemID = "78";
        public static string App_PCName = Environment.MachineName;
        public static string App_accessCode = "C";
        public static string userid;

        public static string app_errorreason;



        public static void CreateConn()
        {
            db_servername = "IS-INTERN02";
            db_databasename = "ProjectHR-02";
            db_userid = "tah";
            db_password = "hr11223344";
            string LBConnstring = "SERVER = " + db_servername + " ;" + "Database = " + db_databasename + ";" + "UID = " + db_userid + ";" + "PWD =" + db_password + ";" + "Connection Timeout=0; " + "Application Name=Wire Addressing System";

            db_con = new SqlConnection(LBConnstring);
            if (db_con.State == ConnectionState.Open)
                db_con.Close();
            try
            {
                db_con.Open();
            }
            catch (SqlException SQLExceptionErr)
            {
                MessageBox.Show(SQLExceptionErr.Message, "Access Error");
            }
            catch (InvalidOperationException InvalidOperationExceptionErr)
            {
                MessageBox.Show(InvalidOperationExceptionErr.Message, "Access Error");
            }
            if (db_con.State != ConnectionState.Open)
            {
                MessageBox.Show("Database connection is Failed");
                return;
            }
        }

        public static DataSet GetDataSet(string SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, db_con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandTimeout = 0;
            try
            {
                da.Fill(ds);
            }
            catch (InvalidOperationException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                str += "Stack Trace : " + ex.StackTrace;
                MessageBox.Show(str, "Specific Exception");
            }
            catch (SqlException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Database Exception");
            }
            catch (Exception ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Generic Exception");
            }

            finally
            {
                if (db_con.State == ConnectionState.Open)
                {
                }
            }

            return ds;
        }
        public static DataTable GetDataTable(string SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, db_con);
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandTimeout = 0;

            try
            {
                da.Fill(table);
            }
            catch (InvalidOperationException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                str += "Stack Trace : " + ex.StackTrace;
                MessageBox.Show(str, "Specific Exception");
            }
            catch (SqlException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Database Exception");
            }
            catch (Exception ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Generic Exception");
            }
            finally
            {
            }

            return table;
        }
        public static bool EXEcuteQuery(string SQL)
        {
            SqlCommand cmd = new SqlCommand(SQL, db_con);
            SqlTransaction thisTransaction;
            thisTransaction = db_con.BeginTransaction();
            cmd.Transaction = thisTransaction;


            try
            {
                cmd.ExecuteNonQuery();
                thisTransaction.Commit();
                app_errorreason = "";
                return true;
            }
            catch (InvalidOperationException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "_";
                str += "Exception Message : " + ex.Message;
                str += "_";
                str += "Stack Trace : " + ex.StackTrace;
                app_errorreason = str;
                MessageBox.Show(str, "Specific Exception");
                return false;
            }
            catch (SqlException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                app_errorreason = str;
                MessageBox.Show(str, "Database Exception");
                thisTransaction.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                app_errorreason = str;
                MessageBox.Show(str, "Generic Exception");
                return false;
            }
            finally
            {
                if (db_con.State == ConnectionState.Open)
                {
                }
            }
        }
        public static string EXEScalar(string SQL)
        {

            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = db_con,
                CommandType = CommandType.Text,
                CommandText = SQL
            };

            try
            {
                var result = sqlCommand.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    return null;
                }
                else
                {
                    return result.ToString();
                }

            }
            catch (InvalidOperationException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                str += "Stack Trace : " + ex.StackTrace;
                MessageBox.Show(str, "Specific Exception");
            }
            catch (SqlException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Database Exception");
            }
            catch (Exception ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Generic Exception");
            }

            finally
            {
            }

            return null;
        }

        public static bool EXEcuteCheckData(string SQL)
        {
            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = db_con,
                CommandType = CommandType.Text,
                CommandText = SQL
            };

            try
            {

                if ((int)sqlCommand.ExecuteScalar() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (InvalidOperationException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                str += "Stack Trace : " + ex.StackTrace;
                MessageBox.Show(str, "Specific Exception");
            }
            catch (SqlException ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Database Exception");
            }
            catch (Exception ex)
            {
                string str;
                str = "Source : " + ex.Source;
                str += "Exception Message : " + ex.Message;
                MessageBox.Show(str, "Generic Exception");
            }

            finally
            {
            }

            return false;
        }
    }
}
