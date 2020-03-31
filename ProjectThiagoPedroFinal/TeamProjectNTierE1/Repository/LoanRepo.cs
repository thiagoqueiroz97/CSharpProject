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
    public class LoanRepo
    {
        public List<Loan> RetrieveByLoanByStudentId(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Retrieve_LoanStu", CommandType.StoredProcedure, parms);

            List<Loan> loans = new List<Loan>();

            foreach (DataRow row in dt.Rows)
            {
                loans.Add(PopulateLoanRecord(row));
            }

            return loans;
        }

        public bool AddLoan(Loan l)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@SID", l.StudentId, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@RID", l.ResourceId, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@ChDate", l.CheckOutDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@DDate", l.DueDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@LoanStatus", l.LoanStatusId, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Loan_Insert", CommandType.StoredProcedure, parms) > 0;
        }

        public bool UpdateLoan(string id, int sts)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@LID", id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@STS", sts, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Loan_Update", CommandType.StoredProcedure, parms) > 0;
        }

        public int CheckIfReturnIsLate(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            
            parms.Add(new ParmStruct("@LID", id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Now", DateTime.Now, SqlDbType.DateTime, ParameterDirection.Input));


            string sql = "SELECT COUNT(*) FROM Loan WHERE DATEDIFF (DAY, CheckOutDate, @Now) > 2 AND LoanID = @LID AND DATEDIFF(DAY, CheckOutDate, @Now) <10";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public int CheckIfResourceUnavailable(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@RID", id, SqlDbType.Int, ParameterDirection.Input));

            string sql = "SELECT COUNT(*) FROM Resource WHERE ResourceStatusID = 3 AND ResourceID = @RID";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public int CheckIfReturnIsMissing(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@LID", id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Now", DateTime.Now, SqlDbType.DateTime, ParameterDirection.Input));


            string sql = "SELECT COUNT(*) FROM Loan WHERE DATEDIFF (DAY, CheckOutDate, @Now) > 10 AND LoanID = @LID";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        private Loan PopulateLoanRecord(DataRow row)
        {
            Loan l = new Loan();

            l.LoanId = row["LoanID"].ToString();
            //l.StudentId = row["StudentID"].ToString();
            l.ResourceId = row["ResourceID"].ToString();
            l.CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]);
            l.DueDate = Convert.ToDateTime(row["DueDate"]);
            //l.LoanStatusId = Convert.ToInt32(row["LoanStatusId"]);
            l.LoanStatus = row["ResourceStatusType"].ToString();
            l.ResourceStatus = row["ResourceStatusType"].ToString();
            l.ResourceImage = row["ResourceImage"].ToString();
            l.ResourceType = row["ResourceType"].ToString();
            l.ResourceTypeId = Convert.ToInt32(row["ResourceTypeID"]);
            l.Title = Convert.ToString(row["Title"]);

            return l;
        }

        
    }
}
