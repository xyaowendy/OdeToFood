using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;
using OdeToFoodCore;

namespace OdeToFood.Pages.Restaurants
{
    public class Detail : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        public Restaurant Restaurant { get; set; }

        public Detail(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        
        public void OnGet(int restaurantId)
        {
            Restaurant = _restaurantData.GetById(restaurantId);
        }
    }
}