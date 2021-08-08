using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediCare.Models
{
    public class Medicines
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }

        public List<Medicines> medicines = new List<Medicines>();
    }
}
