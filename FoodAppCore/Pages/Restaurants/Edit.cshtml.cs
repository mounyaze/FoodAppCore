using FoodAppCore.Core;
using FoodAppCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodAppCore.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        readonly IRestaurantData restaurantData;
        public Restaurant Restaurant{ get; set; }
        public EditModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);

            if (Restaurant == null) 
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
