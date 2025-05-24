using htmxDemo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Reflection;

namespace htmxDemo.Pages.Auth
{
    public class LoginModel : PageModel
    {
        private readonly IModelMetadataProvider _metadataProvider;

        public LoginModel(IModelMetadataProvider metadataProvider)
        {
            _metadataProvider = metadataProvider;
        }

        public IActionResult OnGet()
        {
            var viewModel = new LoginViewModel();
            return new PartialViewResult
            {
                ViewName = "_Login",
                ViewData = new ViewDataDictionary<LoginViewModel>(_metadataProvider, ModelState)
                {
                    Model = viewModel
                }
            };
        }

        public IActionResult OnPostLogin(string username, string password)
        {
            if (username == "a.b@c.com" && password == "password")
            {
                // Simulate a successful login
                HttpContext.Session.SetString("User", "Sanuja");
                return new PartialViewResult
                {
                    ViewName = "_Dashboard"
                };
            }

            var viewModel = new LoginViewModel
            {
                Username = username,
                ErrorMessage = "Username or Password"
            };

            return new PartialViewResult
            {
                ViewName = "_Login",
                ViewData = new ViewDataDictionary<LoginViewModel>(_metadataProvider, ModelState)
                {
                    Model = viewModel
                }
            };
        }
    }
}
