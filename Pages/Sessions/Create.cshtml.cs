using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FacilityApp.Data;
using FacilityApp.Models;

namespace FacilityApp.Pages.Sessions
{
    public class CreateModel : PageModel
    {
        private readonly FacilityApp.Data.ApplicationDbContext _context;

        public CreateModel(FacilityApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClassTypeId"] = new SelectList(_context.ClassTypes, "Id", "Id");
        ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Session Session { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sessions.Add(Session);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
