using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediCare.Models;

namespace MediCare.Data
{
    public class MediCareContext : DbContext
    {
        public MediCareContext (DbContextOptions<MediCareContext> options)
            : base(options)
        {
        }

        public DbSet<MediCare.Models.Medicine> Medicine { get; set; }
        public DbSet<MediCare.Models.Medicines> Medicines { get; set; }

        public DbSet<MediCare.Models.OrderMedicine> OrderMedicine { get; set; }

        public DbSet<MediCare.Models.ContactUs> ContactUs { get; set; }
    }
}
