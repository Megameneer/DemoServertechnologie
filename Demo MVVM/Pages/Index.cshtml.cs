using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_MVVM.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int AmountOfKibbeling { get; set; }

        public IActionResult OnPost()
        {
            HttpContext.Session.SetInt32("amountOfKibbeling", AmountOfKibbeling);
            return RedirectToPage("./Page1");
        }

        public void OnGet()
        {
            Console.WriteLine(HttpContext.Session.GetInt32("amountOfKibbeling"));
        }
    }
}
