using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DAL
{
    public class DAL
    {
        public class DataAccess
        {
            public DataTable Execute(string cmdText, CommandType cmdType, List<ParmStruct> parms = null)
            {
                SqlCommand cmd = CreateCommand(cmdText, cmdType, parms);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;
            }

            public int ExecuteNonQuery(string cmdText, CommandType cmdType, List<ParmStruct> parms = null)
            {
                SqlCommand cmd = CreateCommand(cmdText, cmdType, parms);

                using (cmd.Connection)
                {
                    cmd.Connection.Open();
                    return cmd.ExecuteNonQuery();
                }
            }

            public object ExecuteScaler(string sql, CommandType cmdType, List<ParmStruct> parms = null)
            {
                SqlCommand cmd = CreateCommand(sql, cmdType, parms);
                object retVal;

                using (cmd.Connection)
                {
                    cmd.Connection.Open();
                    retVal = cmd.ExecuteScalar();
                }

                return retVal;
            }

            private SqlCommand CreateCommand(string cmdText, CommandType cmdType, List<ParmStruct> parms)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmpMaint"].ConnectionString);
                //SqlConnection conn = new SqlConnection(
                //    Properties.Settings.Default.cnnString);

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.CommandType = cmdType;

                if (parms != null)
                {
                    foreach (ParmStruct p in parms)
                    {
                        cmd.Parameters.Add(p.Name, p.DataType, p.Size).Value = p.Value;
                    }
                }

                return cmd;
            }
        }
    }
}
