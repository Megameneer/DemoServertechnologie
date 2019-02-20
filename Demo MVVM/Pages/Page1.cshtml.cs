using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_MVVM.Pages
{
    public class Page1Model : PageModel
    {
//        [BindProperty]
        public int AmountOfKibbeling { get; set; }

        public decimal PricePerUnit { get; set; } = 2m;
        public decimal TotalPrice { get; set; }

        public void OnGet()
        {
            var amountOfKibbelingAsNullableInt = HttpContext.Session.GetInt32("amountOfKibbeling");
            if (!amountOfKibbelingAsNullableInt.HasValue) return;
            AmountOfKibbeling = amountOfKibbelingAsNullableInt.Value;
            TotalPrice = AmountOfKibbeling * PricePerUnit;
        }
    }
}
