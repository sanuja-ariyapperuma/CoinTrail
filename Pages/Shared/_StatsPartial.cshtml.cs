using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace htmxDemo.Pages.Shared
{
    public class _StatsPartial : PageModel
    {
        private readonly ILogger<_StatsPartial> _logger;

        public _StatsPartial(ILogger<_StatsPartial> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}