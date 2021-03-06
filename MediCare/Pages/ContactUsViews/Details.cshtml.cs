using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediCare.Data;
using MediCare.Models;

namespace MediCare.Pages.ContactUsViews
{
    public class DetailsModel : PageModel
    {
        private readonly MediCare.Data.MediCareContext _context;

        public DetailsModel(MediCare.Data.MediCareContext context)
        {
            _context = context;
        }

        public ContactUs ContactUs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactUs = await _context.ContactUs.FirstOrDefaultAsync(m => m.id == id);

            if (ContactUs == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
