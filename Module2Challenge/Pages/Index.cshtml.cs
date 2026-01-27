using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double MilesDriven { get; set; }

    [BindProperty]
    public double GallonsUsed { get; set; }

    public double MilesPerGallon { get; set; }
    public bool ShowResult { get; set; }
  

    public void OnGet()
    {
        ShowResult = false;
    }

    public void OnPost()
    {
        ShowResult = false;

       
        // Calculate MPG
        double mpg = MilesDriven / GallonsUsed;
        MilesPerGallon = mpg;

        ShowResult = true;
    }
}
