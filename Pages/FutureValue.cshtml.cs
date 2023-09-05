using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperWeb.Models;

namespace SyperWeb.Pages
{
    public class FutureValueModel : PageModel
    {
        [BindProperty]
        public FutureValue? FutureValue { get; set; }

        public void OnGet()
        {
            ViewData["FV"] = 0;
        }

        public void OnPost() {
            ViewData["FV"] = FutureValue!.CalculateFutureValue();
        }
    }
}
