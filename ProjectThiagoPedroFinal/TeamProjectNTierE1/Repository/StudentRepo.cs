using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DAL;

namespace Repository
{
    public class StudentRepo
    {
        public Student RetrieveById(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));
           
            DataAccess db = new DataAccess();
            System.Data.DataTable dt = db.Execute("Retrieve_Student", CommandType.StoredProcedure, parms);

            return PopulateStudentRecord(dt.Rows[0]);
        }

        public Student RetrieveByResourceId(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@RID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            DataAccess db = new DataAccess();
            System.Data.DataTable dt = db.Execute("Retrieve_Student_Via_Resource", CommandType.StoredProcedure, parms);

            return PopulateStudentRecord(dt.Rows[0]);
        }

        public Student RetrieveWithConcurrency(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            DataAccess db = new DataAccess();
            System.Data.DataTable dt = db.Execute("Retrieve_Student_Conc", CommandType.StoredProcedure, parms);

            return PopulateStudentRecordMaintModule(dt.Rows[0]);
        }

        public bool UpdateAmmountMissing(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@LID", id, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Update_Student_Due_Missing", CommandType.StoredProcedure, parms) > 0;
        }

        public bool Insert(Student student)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@TimeStamp", student.TimeStamp, SqlDbType.Timestamp, ParameterDirection.Output));
            parms.Add(new ParmStruct("@SID", student.StudentId, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@Status", student.StudentStatus, SqlDbType.Bit, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Fname", student.FirstName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@Lname", student.LastName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@Start", student.StartDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@End", student.EndDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PID", student.ProgramId, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Address", student.Address, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@City", student.City, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PostalCode", student.PostalCode, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Phone", student.PhoneNumber, SqlDbType.VarChar, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            if (db.ExecuteNonQuery("Student_Insert", CommandType.StoredProcedure, parms) > 0)
            {
                student.TimeStamp = (byte[])parms[0].Value;
                return true;
            }
            return false;
        }

        public bool UpdateAmmountDue(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@LID", id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Now", DateTime.Now, SqlDbType.DateTime, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Update_Student_Due", CommandType.StoredProcedure, parms) > 0;
        }

        public bool Delete(string studentId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@SID", studentId, SqlDbType.VarChar, ParameterDirection.Input, 8));

            DataAccess db = new DataAccess();
            int retVal = db.ExecuteNonQuery("Delete_Student", CommandType.StoredProcedure, parms);

            if (retVal > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(Student student)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@TimeStamp", student.TimeStamp, SqlDbType.Timestamp, ParameterDirection.InputOutput));
            parms.Add(new ParmStruct("@SID", student.StudentId, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@Status", student.StudentStatus, SqlDbType.Bit, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Fname", student.FirstName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@Lname", student.LastName, SqlDbType.VarChar, ParameterDirection.Input, 30));
            parms.Add(new ParmStruct("@Start", student.StartDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@End", student.EndDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PID", student.ProgramId, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@AMTD", student.AmountDue, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Address", student.Address, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@City", student.City, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PostalCode", student.PostalCode, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Phone", student.PhoneNumber, SqlDbType.VarChar, ParameterDirection.Input));


            DataAccess db = new DataAccess();
           if(db.ExecuteNonQuery("Student_Update", CommandType.StoredProcedure, parms) > 0)
            {
                student.TimeStamp = (byte[])parms[0].Value;
                return true;
            }
            return false;
        }

        public int CheckStudentDue(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            string sql = "SELECT COUNT(*) FROM Student WHERE StudentID = @SID AND AmountDue > 0";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public bool MakePayment(string id, string name, decimal pay)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@FuName", name, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@Pay", pay, SqlDbType.Money, ParameterDirection.Input));
            parms.Add(new ParmStruct("@DateAdded", DateTime.Now, SqlDbType.DateTime, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Payment_Insert", CommandType.StoredProcedure, parms) > 0;
        }

        public int CheckIfStudentIsActive(string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));

            string sql = "SELECT COUNT(*) FROM Student WHERE StudentID = @SID AND StudentStatus = 0";

            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }


        public int CheckLoans(string id, int typeId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));
            parms.Add(new ParmStruct("@TypeID", typeId, SqlDbType.Int, ParameterDirection.Input));

            string sql = "SELECT COUNT(*) FROM Loan INNER JOIN Resource ON Loan.ResourceID = Resource.ResourceID WHERE LoanStatusID = 1  and ResourceTypeID = @TypeID AND StudentID = @SID";
            DataAccess db = new DataAccess();
            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        private Student PopulateStudentRecord(DataRow row)
        {
            Student s = new Student();

            s.StudentId = row["StudentID"].ToString();
            if (Convert.ToBoolean(row["StudentStatus"]) == true)
            {
                s.StudentStatus = "Active";
            }
            else if (Convert.ToBoolean(row["StudentStatus"]) == false)
            {
                s.StudentStatus = "Inactive";
            }
            s.FirstName = row["FirstName"].ToString();
            s.LastName = row["LastName"].ToString();
            s.StartDate = Convert.ToDateTime(row["StartDate"]);
            s.EndDate = Convert.ToDateTime(row["EndDate"]);
            s.Program = row["ProgramType"].ToString();
            s.AmountDue = Convert.ToDecimal(row["AmountDue"]);
            s.ProgramId = Convert.ToInt32(row["ProgramID"]);

            return s;
        }

        private Student PopulateStudentRecordMaintModule(DataRow row)
        {
            Student s = new Student();

            s.StudentId = row["StudentID"].ToString();
            if (Convert.ToBoolean(row["StudentStatus"]) == true)
            {
                s.StudentStatus = "Active";
            }
            else if (Convert.ToBoolean(row["StudentStatus"]) == false)
            {
                s.StudentStatus = "Inactive";
            }
            s.FirstName = row["FirstName"].ToString();
            s.LastName = row["LastName"].ToString();
            s.StartDate = Convert.ToDateTime(row["StartDate"]);
            s.EndDate = Convert.ToDateTime(row["EndDate"]);
            s.Program = row["ProgramType"].ToString();
            s.AmountDue = Convert.ToDecimal(row["AmountDue"]);
            s.ProgramId = Convert.ToInt32(row["ProgramID"]);
            s.TimeStamp = (byte[])row["TimeStamp"];
            s.Address = row["Address"].ToString();
            s.City = row["City"].ToString();
            s.PostalCode = row["PostalCode"].ToString();
            s.PhoneNumber = row["PhoneNumber"].ToString();

            return s;
        }

    }
}
