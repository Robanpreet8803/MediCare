using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MediCare.Data;
using MediCare.Models;

namespace MediCare.Pages.OrderViewMedicine
{
    public class DetailsModel : PageModel
    {
        private readonly MediCare.Data.MediCareContext _context;

        public DetailsModel(MediCare.Data.MediCareContext context)
        {
            _context = context;
        }

        public OrderMedicine OrderMedicine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderMedicine = await _context.OrderMedicine.FirstOrDefaultAsync(m => m.id == id);

            if (OrderMedicine == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
