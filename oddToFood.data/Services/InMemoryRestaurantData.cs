﻿using oddToFood.data.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace oddToFood.data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ID=1,Name="Vinithsai restaurant",Cuisine=CuisineType.Italian},
                new Restaurant{ID=2,Name="altera restaurant",Cuisine=CuisineType.French},
                new Restaurant{ID=3,Name="Mango Groove",Cuisine=CuisineType.Indian},
            };

        }
        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.ID = restaurants.Max(r => r.ID) + 1;
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.ID);
            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.ID == id); 
        }

        public IEnumerable<Restaurant>GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
        public void Delete(int id)
        {
            var restaurant = Get(id);
            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
        }
    }
}
