using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class _LoginModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public _LoginModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void OnGet()
        {
        }

    public IActionResult OnPostLogin(string username, string password)
    {
        // Example: Simple login check (you can use your own logic here)
        if (username == "admin" && password == "password")
        {
            // Set session or cookie to indicate the user is logged in
            _httpContextAccessor.HttpContext.Session.SetString("LoggedIn", "true");
            return RedirectToPage("/Dashboard"); // Redirect to dashboard
        }

        // If login fails, just return the login page again (add error message)
        return Page();
    }
    }
}
