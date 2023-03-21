using FoodAppCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAppCore.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            
            restaurants = new List<Restaurant>()
            {
                new Restaurant() { ID =1, Name="Le merisier", Location="Agdal", Cuisine=CuisineType.Moroccan},
                new Restaurant() { ID =2, Name="Yamal cham", Location="Agdal", Cuisine=CuisineType.Syrian},
                new Restaurant() { ID =3, Name="Mcdonalds'", Location="Medina", Cuisine=CuisineType.American}

            };
            
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants where string.IsNullOrEmpty(name) || r.Name.StartsWith(name) 
                   orderby r.Name 
                   select r;
        }
    }
}
