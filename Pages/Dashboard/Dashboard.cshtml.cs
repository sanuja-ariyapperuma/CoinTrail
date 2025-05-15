using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DashboardModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DashboardModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult  OnGet()
        {
            var loggedIn = _httpContextAccessor.HttpContext.Session.GetString("LoggedIn");

            // If the user is not logged in, redirect to the login page
            if (string.IsNullOrEmpty(loggedIn))
            {
                return RedirectToPage("/Login");
            }

            return Page();
        }
    }
}
