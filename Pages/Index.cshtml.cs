using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace htmxDemo.Pages;

public class IndexModel : PageModel
{
    private static readonly Random Random = new();
    public int TotalUsers { get; private set; }
    public void OnGet()
    {
        TotalUsers = Random.Next(1000, 5000);
    }
    public IActionResult OnGetStats()
    {
        var updatedCount = Random.Next(1000, 5000);
        return Partial("_StatsPartial", updatedCount);
    }
}
