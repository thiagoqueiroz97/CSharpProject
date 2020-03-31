using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace BLL
{
    public class ValidationError
    {
        public ValidationError(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
