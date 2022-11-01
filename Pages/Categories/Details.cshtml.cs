using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ihut_Alexandra_Lab2.Data;
using Ihut_Alexandra_Lab2.Models;

namespace Ihut_Alexandra_Lab2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Ihut_Alexandra_Lab2.Data.Ihut_Alexandra_Lab2Context _context;

        public DetailsModel(Ihut_Alexandra_Lab2.Data.Ihut_Alexandra_Lab2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
