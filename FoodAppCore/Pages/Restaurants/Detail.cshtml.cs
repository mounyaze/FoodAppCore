using FoodAppCore.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodAppCore.Pages.Restaurants
{
     
    public class DetailModel : PageModel
    {
        public Restaurant  Restaurant { get; set; }
        public void OnGet(int restaurantId)
        {
            Restaurant = new Restaurant();
            Restaurant.ID = restaurantId;
        }
    }
}
