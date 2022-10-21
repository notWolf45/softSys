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
    public class IndexModel : PageModel
    {
        private readonly softSys_1.Models.Context _context;

        public IndexModel(softSys_1.Models.Context context)
        {
            _context = context;
        }
        
        [BindProperty]
        public string aName {get; set;}
        public users Name {get; set;}

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (aName == null)
            {
                return NotFound();
            }
            Name = _context.users.Where(h => h.Name.ToLower() == aName.ToLower()).FirstOrDefault();
            //return RedirectToPage("./Index");
            return Page();
        }
    }
}
