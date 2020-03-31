using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace BLL
{
    public class ResourceBL
    {
        public List<ValidationError> Errors = new List<ValidationError>();

        public Resource GetResource(string id = "")
        {
            ResourceRepo repo = new ResourceRepo();
            return repo.RetrieveByResourceId(id);
        }

        private bool IsResourceReserved(string id)
        {
            ResourceRepo repo = new ResourceRepo();

            if (repo.CheckIfResourceReservedForm3(id) > 0)
            {
                Errors.Add(new ValidationError("This resource cannot be reserved since its already reserved by another student."));
                return false;
            }
            return true;
        }

        private bool IsResourceAvailable(string id)
        {
            ResourceRepo repo = new ResourceRepo();

            if (repo.CheckIfResourceAvailable(id) > 0)
            {
                Errors.Add(new ValidationError("This resource cannot be reserved since its not available anymore."));
                return false;
            }
            return true;
        }

        private void Validate(string id)
        {
            IsResourceReserved(id);
            IsResourceAvailable(id);
        }

        

        public Resource GetResourceForm3(string id)
        {
            ResourceRepo repo = new ResourceRepo();

            Validate(id);

            if (Errors.Count == 0)
            {
                return repo.RetrieveByResourceId(id);
            }

            return repo.RetrieveByResourceId(id); ;
            
        }

        public bool UpdateResource(string id)
        {
            ResourceRepo repo = new ResourceRepo();

            return repo.UpdateResource(id);
        }

        public bool UpdateResource2(Resource re)
        {
            ResourceRepo repo = new ResourceRepo();

            return repo.UpdateResource2(re);
        }

        public bool ReserveResource(string rid, string sid, string name)
        {
            ResourceRepo repo = new ResourceRepo();

            return repo.MakeReserve(rid, sid, name);
        }
    }
}
