using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FacilityApp.Data;
using FacilityApp.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using BCryptNet = BCrypt.Net.BCrypt;

namespace FacilityApp.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public RegisterModel(ApplicationDbContext context) => _context = context;

        [BindProperty]
        public RegisterInput Input { get; set; } = new();

        public class RegisterInput
        {
            [Required, StringLength(50)]
            public string FirstName { get; set; } = string.Empty;

            [Required, StringLength(50)]
            public string LastName { get; set; } = string.Empty;

            [Required, EmailAddress]
            public string Email { get; set; } = string.Empty;

            [Required, StringLength(100, MinimumLength = 6)]
            public string Password { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            // Ensure unique email
            var exists = await _context.Users.AnyAsync(u => u.Email == Input.Email);
            if (exists)
            {
                ModelState.AddModelError(string.Empty, "Email is already registered.");
                return Page();
            }

            // Create member with hashed password
            var user = new User
            {
                FirstName = Input.FirstName,
                LastName  = Input.LastName,
                Email     = Input.Email,
                PasswordHash = BCryptNet.HashPassword(Input.Password),
                Role = "member"
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Auto-login
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserRole", user.Role);

            return RedirectToPage("/Members/Dashboard");
        }
    }
}
