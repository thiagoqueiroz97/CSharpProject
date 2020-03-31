using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Resource
    {
        [Required]
        public string ResourceId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int ResourceTypeId { get; set; }

        public string ResourceType { get; set; }

        public string ResourceStatusType { get; set; }

        public int PublisherReference { get; set; }

        [Required]
        public int ResourceStatusId { get; set; }

        public DateTime DateRemoved { get; set; }


        public string ResourceImage { get; set; }

        [Required]
        public decimal ResourcePrice { get; set; }

        public bool ReserveStatus { get; set; }

        public string ReserveStudentId { get; set; }

        public string ReserveStudentName { get; set; }
    }
}
