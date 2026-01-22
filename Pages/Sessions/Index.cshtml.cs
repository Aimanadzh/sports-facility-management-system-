using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FacilityApp.Data;
using FacilityApp.Models;

namespace FacilityApp.Pages.Sessions
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Session> Sessions { get;set; } = new List<Session>();

        public async Task OnGetAsync()
        {
            Sessions = await _context.Sessions
                .Include(s => s.ClassType)
                .Include(s => s.Room)
                .Include(s => s.Instructor)   // Instructor navigation
                .ToListAsync();
        }
    }
}
