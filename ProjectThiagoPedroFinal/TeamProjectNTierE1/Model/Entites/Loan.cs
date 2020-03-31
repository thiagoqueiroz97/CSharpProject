using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Loan
    {
        [Required]
        public string LoanId { get; set; }

        [Required]
        public string StudentId { get; set; }

        [Required]
        public string ResourceId { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int LoanStatusId { get; set; }

        [Required]
        public int ResourceTypeId { get; set; }

        public string ResourceImage { get; set; }

        public string ResourceType { get; set; }

        public string LoanStatus {get; set;}

        public string Title { get; set; }

        public string ResourceStatus { get; set; }
    }
}
