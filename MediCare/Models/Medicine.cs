﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediCare.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        [Display(Name = "Medicine Name ")]
        public string MedicineName { get; set; }

        [Display(Name = "Strips ")]
        public string Strips { get; set; }        
        
        [Display(Name = "Company ")]
        public string Company { get; set; }
        
        [Display(Name = "Rate ")]
        public string Rate { get; set; }


    }
}
