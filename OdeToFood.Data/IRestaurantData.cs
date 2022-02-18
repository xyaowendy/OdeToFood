﻿using System.Collections.Generic;
using System.Linq;
using OdeToFoodCore;

namespace OdeToFood.Data
{
    public interface IRestaurantData
        {
            IEnumerable<Restaurant> GetRestaurantsByName(string name);
            Restaurant GetById(int id);
        }

        public class InMemoryRestaurantData : IRestaurantData
        {
            List<Restaurant> restaurants;

            public InMemoryRestaurantData()
            {
                restaurants = new List<Restaurant>()
                {
                    new Restaurant {Id = 1, Name = "Pizza", Location = "Maryland", Cuisine = CuisineType.Italian},
                    new Restaurant {Id = 2, Name = "taco bell", Location = "Southport", Cuisine = CuisineType.Mexican},
                    new Restaurant {Id = 3, Name = "Taj Palace", Location = "Surfers Paradise", Cuisine = CuisineType.Indian}
                };
            }

            public Restaurant GetById(int id)
            {
                return restaurants.SingleOrDefault(r => r.Id == id);
            }
    
            public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
            {
                return from r in restaurants
                    where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                    orderby r.Name
                    select r;
            }
        }
    }