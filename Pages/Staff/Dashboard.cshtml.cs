using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FacilityApp.Pages.Staff
{
    public class DashboardModel : PageModel
    {
        public IActionResult OnGet()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "staff") return RedirectToPage("/Account/Login");
            return Page();
        }
    }
}
