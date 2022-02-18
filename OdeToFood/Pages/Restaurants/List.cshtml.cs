﻿using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;
using OdeToFoodCore;

namespace OdeToFood.Pages.Restaurants
{
    public class List : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IRestaurantData _restaurantData;
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants  { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        
        public List(IConfiguration config, IRestaurantData restaurantData)
        {
            _config = config;
            _restaurantData = restaurantData;
        }
        
        public void OnGet()
        {
            Message = _config["Message"];
            Restaurants = _restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}