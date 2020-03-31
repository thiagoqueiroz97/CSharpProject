using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        [Required]
        [StringLength(8, ErrorMessage = "The id cannot have more than 8 characters.")]
        [RegularExpression("[1-2][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", ErrorMessage = "Student ID is not in the proper format.")]
        public string StudentId { get; set; }

        [Required]
        public string StudentStatus { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int ProgramId { get; set; }

        public string Program { get; set; }

        
        public decimal AmountDue { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [RegularExpression("[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVXY][0-9]", ErrorMessage = "Postal code not valid.")]
        public string PostalCode { get; set; }
        [Required]
        [Phone(ErrorMessage = "Invalid Phone number.")]
        public string PhoneNumber { get; set; }

        public byte[] TimeStamp { get; set; }

    }
}
