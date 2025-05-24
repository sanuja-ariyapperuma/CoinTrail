using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace htmxDemo.Pages.Auth
{
    public class SignUpModel : PageModel
    {
        public IActionResult OnGet()
        {
            return new PartialViewResult
            {
                ViewName = "_SignUp"
            };
        }
    }
}
