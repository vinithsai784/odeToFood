﻿using oddToFood.data.models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddToFood.data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(int id);
    }
}
