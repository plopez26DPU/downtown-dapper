using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Downtown_Dapper.Pages;

public class Services : PageModel
{
    private readonly ILogger<Services> _logger;

    public Services(ILogger<Services> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

