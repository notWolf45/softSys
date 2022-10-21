using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using softSys_1.Models;

namespace softSys_1.Pages.Grocery
{
    public class OrderModel : PageModel
    {
        private readonly softSys_1.Models.Context _context;

        public OrderModel(softSys_1.Models.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public string order {get; set;}
        public Stores store {get; set;}

        public void OnGet()
        {

        }

         public async Task<IActionResult> OnPostAsync()
        {
            if (order == null)
            {
                return NotFound();
            }
            store = _context.Stores.Where(h => h.food.ToLower() == order.ToLower()).FirstOrDefault();
            //return RedirectToPage("./Index");
            return Page();
        }
    }
}