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
    public class DeleteModel : PageModel
    {
        private readonly MediCare.Data.MediCareContext _context;

        public DeleteModel(MediCare.Data.MediCareContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Medicine Medicine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicine = await _context.Medicine.FirstOrDefaultAsync(m => m.Id == id);

            if (Medicine == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicine = await _context.Medicine.FindAsync(id);

            if (Medicine != null)
            {
                _context.Medicine.Remove(Medicine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
