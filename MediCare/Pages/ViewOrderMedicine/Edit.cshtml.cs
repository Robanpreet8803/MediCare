﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediCare.Data;
using MediCare.Models;

namespace MediCare.Pages.OrderViewMedicine
{
    public class EditModel : PageModel
    {
        private readonly MediCare.Data.MediCareContext _context;

        public EditModel(MediCare.Data.MediCareContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderMedicine OrderMedicine { get; set; }
        public IEnumerable<Medicine> medicines { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OrderMedicine = await _context.OrderMedicine.FirstOrDefaultAsync(m => m.id == id);

            medicines = await _context.Medicine.ToListAsync();
            if (OrderMedicine == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OrderMedicine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderMedicineExists(OrderMedicine.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OrderMedicineExists(int id)
        {
            return _context.OrderMedicine.Any(e => e.id == id);
        }
    }
}
