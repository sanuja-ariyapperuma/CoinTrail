using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnGetLoginPartial()
        {
            return Partial("_Login");  // Return only the login form
        }

        public IActionResult OnGetSignupPartial()
        {
            return Partial("_SignUp");  // Return only the signup form
        }
    }
}
