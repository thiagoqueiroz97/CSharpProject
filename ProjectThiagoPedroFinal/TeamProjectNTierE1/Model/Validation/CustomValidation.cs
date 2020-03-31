using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class SatartDateAttribute : ValidationAttribute
    {
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    Student stu = new Student();
        //    if ((DateTime)value <= stu.EndDate)
        //    {
        //        return ValidationResult.Success;
        //    }

        //    return new ValidationResult("Date cannot be greater than End Date.");
        //}
    }
}
