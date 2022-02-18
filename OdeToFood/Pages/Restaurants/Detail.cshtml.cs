using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFoodCore;

namespace OdeToFood.Pages.Restaurants
{
    public class Detail : PageModel
    {
        public Restaurant Restaurant { get; set; }
        
        public void OnGet()
        {
            Restaurant = new Restaurant();
        }
    }
}