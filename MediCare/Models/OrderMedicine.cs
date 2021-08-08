using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediCare.Models
{
    public class OrderMedicine
    {
        public int id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }

        [Display(Name = "Medicine Id ")]
        public int MedicineId { get; set; }

        [Display(Name = "No Of Strip")]
        public string Strips { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
