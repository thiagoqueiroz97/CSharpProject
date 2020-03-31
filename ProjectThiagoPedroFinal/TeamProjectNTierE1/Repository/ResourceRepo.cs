using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DAL;
using Model;
using System.Data;

namespace Repository
{
    public class ResourceRepo
    {
        public Resource RetrieveByResourceId(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            DataAccess db = new DataAccess();
            System.Data.DataTable dt = db.Execute("Retrieve_Resource", CommandType.StoredProcedure, parms);

            return PopulateResourceRecord(dt.Rows[0]);
        }

        public bool UpdateResource(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Set_Resource_Status", CommandType.StoredProcedure, parms) > 0;

        }

        public bool UpdateResource2(Resource re)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", re.ResourceId, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@RSTAT", re.ResourceStatusId, SqlDbType.Int, ParameterDirection.Input));


            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Set_Resource_Status_2", CommandType.StoredProcedure, parms) > 0;

        }

        public bool MakeReserve(string rid, string sid, string name)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", rid, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@SID", sid, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@FuName", name, SqlDbType.VarChar, ParameterDirection.Input, 50));


            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Reserve_Resource", CommandType.StoredProcedure, parms) > 0;

        }

        public int ResourceStatusIsOnloan(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            string sql = "SELECT COUNT(*) FROM Resource WHERE ResourceID = @RID AND ResourceStatusID = 2";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public int CheckIfResourceLoaned(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            string sql = "SELECT COUNT(*) FROM Resource WHERE ResourceID = @RID AND ResourceStatusID = 2";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public int CheckIfResourceReserved(string id, string sid)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            string sql = "SELECT COUNT(*) FROM Resource INNER JOIN Student ON Resource.ReserveStudentID = Student.StudentID AND StudentID = @SID";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public int CheckIfResourceReservedForm3(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            string sql = "SELECT COUNT(*) FROM Resource WHERE ResourceID = @RID AND ReserveStatus = 'TRUE'";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public int CheckIfResourceAvailable(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            string sql = "SELECT COUNT(*) FROM Resource WHERE ResourceID = @RID AND ResourceStatusID = 3";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        private Resource PopulateResourceRecord(DataRow row)
        {
            Resource r = new Resource();

            r.ResourceId= row["ResourceID"].ToString();
            r.ResourceType = row["ResourceType"].ToString();
            //r.PublisherReference = Convert.ToInt32(row["PublisherReference"]);
            r.ResourceStatusType = row["ResourceStatusType"].ToString();
            //r.DateRemoved = Convert.ToDateTime(row["DateRemoved"]);
            r.ResourceImage = row["ResourceImage"].ToString();
            //r.ResourcePrice = Convert.ToDecimal(row["ResourcePrice"]);
            r.ReserveStatus = Convert.ToBoolean(row["ReserveStatus"]);
            r.ReserveStudentId = Convert.ToString(row["ReserveStudentID"]);
            r.ReserveStudentName = Convert.ToString(row["ReserveStudentName"]);
            r.ResourceTypeId = Convert.ToInt32(row["ResourceTypeID"]);
            r.Title = Convert.ToString(row["Title"]);

            return r;
        }
    }
}
