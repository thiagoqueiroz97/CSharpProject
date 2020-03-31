using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace BLL
{
    public class LoanBL
    {
        private Loan _lo = new Loan();
        public List<ValidationError> Errors = new List<ValidationError>();

        public List<Loan> GetLoan(string id = "")
        {
            LoanRepo repo = new LoanRepo();
            return repo.RetrieveByLoanByStudentId(id);
        }

        private bool IsStudentOwing(string id)
        {
            StudentRepo repo = new StudentRepo();

            if (repo.CheckStudentDue(id) > 0)
            {
                Errors.Add(new ValidationError("This student cannot borrow any resources until he pays his due."));
                return false;
            }
            return true;
        }

        private bool IsStudentInactive(string id)
        {
            StudentRepo repo = new StudentRepo();

            if (repo.CheckIfStudentIsActive(id) > 0)
            {
                Errors.Add(new ValidationError("This student cannot borrow any resources since he is inactive."));
                return false;
            }
            return true;
        }

        private bool IsLoaned(string id)
        {
            ResourceRepo repo = new ResourceRepo();
            if (repo.ResourceStatusIsOnloan(id) > 0)
            {
                Errors.Add(new ValidationError("This resource is already loaned"));
                return false;
            }
            return true;
        }

        private bool IsResourceReserved(string id, string sid)
        {
            ResourceRepo repo = new ResourceRepo();

            if(repo.CheckIfResourceReserved(id, sid) != 1)
            {
                Errors.Add(new ValidationError("This student cannot borrow this resource since its already reserved by another student."));
                return false;
            }
            return true;
        }

        private bool IsmoreThanOneLoan(string id, int typeId)
        {
            StudentRepo repo = new StudentRepo();

            if (repo.CheckLoans(id, typeId) > 0)
            {
                Errors.Add(new ValidationError("This student cannot borrow a resource of this type since he already has one."));
                return false;
            }
            return true;
        }

        private bool IsReturnLate(string id)
        {
            LoanRepo repo = new LoanRepo();
            if (repo.CheckIfReturnIsLate(id) > 0)
            {
                Errors.Add(new ValidationError("This student is returning this resource late and will be charged for it"));
                return true;
            }
            return false;

        }

        private bool IsResourceMissing(string id)
        {
            LoanRepo repo = new LoanRepo();
            if (repo.CheckIfReturnIsMissing(id) > 0)
            {
                Errors.RemoveAt(0);
                Errors.Add(new ValidationError("This resource is missing for 10 days and will be concidered lost, resource price will be charged to student"));
                return true;

            }
            return false;
        }

        private void Validate(Loan lo, Resource re)
        {
            IsStudentOwing(lo.StudentId);
            IsStudentInactive(lo.StudentId);
            IsmoreThanOneLoan(lo.StudentId, lo.ResourceTypeId);
            IsResourceUnavailable(lo.ResourceId);
            IsLoaned(lo.ResourceId);
            if (re.ReserveStatus == true && lo.StudentId != re.ReserveStudentId)
            {
                IsResourceReserved(lo.ResourceId, lo.StudentId);
            }
        }

        private bool IsResourceUnavailable(string id)
        {
            LoanRepo repo = new LoanRepo();
            if (repo.CheckIfResourceUnavailable(id) > 0)
            {
                Errors.Add(new ValidationError("This resource is no longer in the library."));
                return true;

            }
            return false;
        }

        public bool 
        CreateLoan(Loan loan, Resource re)
        {
            _lo = loan;

            LoanRepo repo = new LoanRepo();
            
            Validate(_lo, re);

            if (Errors.Count == 0)
            {
                return repo.AddLoan(loan);
            }

            return false;

        }

        public bool UpdateLoan(string id, int sts)
        {
            LoanRepo repo = new LoanRepo();
            if (IsReturnLate(id))
            {
                StudentBL stuBl = new StudentBL();
                stuBl.UpdatePrice(id);
            }

            if (sts == 3)
            {
                StudentBL stuBl = new StudentBL();
                stuBl.UpdatePriceMissing(id);
            }

            else if (IsResourceMissing(id) || sts == 4)
            {
                StudentBL stuBl = new StudentBL();
                stuBl.UpdatePriceMissing(id);
                sts = 4;
            }
            
            return repo.UpdateLoan(id, sts);
            
            
        }

    }
}
