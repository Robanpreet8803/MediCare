using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediCare.Data;
using MediCare.Models;

namespace MediCare.Pages.ViewMedicine
{
    public class IndexModel : PageModel
    {
        private readonly MediCare.Data.MediCareContext _context;

        public IndexModel(MediCare.Data.MediCareContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; }

        public async Task OnGetAsync()
        {
            Medicine = await _context.Medicine.ToListAsync();
        }
    }
}
