using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Types;

namespace Repository
{
    public class ListsRepo
    {

        public List<StudentLookup> RetrieveStudentsList(string Lname, string id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@LName", Lname, SqlDbType.VarChar, ParameterDirection.Input, 15));
            parms.Add(new ParmStruct("@SID", id, SqlDbType.VarChar, ParameterDirection.Input, 8));
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Student_Lookup", CommandType.StoredProcedure, parms);

            List<StudentLookup> students = new List<StudentLookup>();

            foreach (DataRow row in dt.Rows)
            {
                students.Add(
                    new StudentLookup()
                    {
                        StudentId = row["StudentId"].ToString(),
                        FullName = row["FirstName"].ToString() + " " + row["LastName"].ToString()
                    }
                );
            }

            return students;
        }

    }
}
