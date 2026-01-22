using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FacilityApp.Data;
using FacilityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using BCryptNet = BCrypt.Net.BCrypt;  // alias

namespace FacilityApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public LoginModel(ApplicationDbContext context) => _context = context;

        [BindProperty]
        public LoginInput Input { get; set; } = new();

        public string ErrorMessage { get; set; } = string.Empty;

        public class LoginInput
        {
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == Input.Email);

            // Verify using BCrypt
            if (user == null || !BCryptNet.Verify(Input.Password, user.PasswordHash))
            {
                ErrorMessage = "Invalid email or password.";
                return Page();
            }

            // Save session
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserRole", user.Role);

            // Redirect by role
            return user.Role switch
            {
                "admin"  => RedirectToPage("/Admin/Dashboard"),
                "staff"  => RedirectToPage("/Staff/Dashboard"),
                "member" => RedirectToPage("/Members/Dashboard"),
                _        => RedirectToPage("/Index")
            };
        }
    }
}
