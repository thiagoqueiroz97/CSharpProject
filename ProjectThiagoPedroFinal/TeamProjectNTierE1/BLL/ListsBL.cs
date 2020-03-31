using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace BLL
{
    public class ListsBL
    {
        public List<StudentLookup> GetStudent(string Lname = "", string id = "")
        {
            ListsRepo repo = new ListsRepo();
            return repo.RetrieveStudentsList(Lname, id);
        }



    }
}
