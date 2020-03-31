using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class StudentBL
    { 
        public List<ValidationError> Errors = new List<ValidationError>();


        public Student GetStudent(string id="")
        {

            StudentRepo repo = new StudentRepo();

            return repo.RetrieveById(id);
          
        }

        public Student GetStudentForm3(string id = "")
        {

            StudentRepo repo = new StudentRepo();

            Validate(id);

            if (Errors.Count == 0)
            {
                return repo.RetrieveById(id);
            }

            return repo.RetrieveById(id);

        }

        public Student GetStudentForm6(string id = "")
        {

            StudentRepo repo = new StudentRepo();

            return repo.RetrieveWithConcurrency(id);

        }

        private bool IsValidEntity(Student student)
        {
            ValidationContext context = new ValidationContext(student);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(student, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new ValidationError(r.ErrorMessage));
            }

            return isValid;
        }

        public void Validate(string id)
        {
            IsStudentInactive(id);
            IsStudentOwing(id);
        }

        public bool AddStudent(Student student)
        {
            StudentRepo repo = new StudentRepo();
            if (IsValidEntity(student)) {
                return repo.Insert(student);
            }
            return false;
        }

        public bool IsStudentInactive(string id)
        {
            StudentRepo repo = new StudentRepo();

            if (repo.CheckIfStudentIsActive(id) > 0)
            {
                Errors.Add(new ValidationError("This resource cannot be reserved since this student is inactive."));
                return false;
            }
            return true;
        }

        public bool IsStudentOwing(string id)
        {
            StudentRepo repo = new StudentRepo();

            if (repo.CheckStudentDue(id) > 0)
            {
                Errors.Add(new ValidationError("This resource cannot be reserved since this student is owing us money."));
                return false;
            }
            return true;
        }

        public bool IsStudentOwingDel(string id)
        {
            StudentRepo repo = new StudentRepo();

            if (repo.CheckStudentDue(id) > 0)
            {
                Errors.Add(new ValidationError("Student cannot be deleted since they owe us money."));
                return false;
            }
            return true;
        }

        public Student GetStudentByResourceId(string id)
        {
            StudentRepo repo = new StudentRepo();
            return repo.RetrieveByResourceId(id);
        }


        internal void UpdatePrice(string id)
        {
            StudentRepo repo = new StudentRepo();
            repo.UpdateAmmountDue(id);
        }

        internal void UpdatePriceMissing(string id)
        {
            StudentRepo repo = new StudentRepo();
            repo.UpdateAmmountMissing(id);
        }

        public bool MakePayment(string id, string name, decimal pay)
        {
            StudentRepo repo = new StudentRepo();

            return repo.MakePayment(id, name, pay);
        }

        public bool ModifyStudent(Student student)
        {
            StudentRepo repo = new StudentRepo();

            return repo.Update(student);
        }

        public bool DeleteStudent(string studentId)
        {
            StudentRepo repo = new StudentRepo();
            if (IsStudentOwingDel(studentId))
            {
                return repo.Delete(studentId);
            }
            return false;
        }
    }
}
