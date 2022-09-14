using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddToFood.data.models
{
    public class Restaurant
    {
        public int ID { get; set; }

        [Required]
        public  string Name { get; set; }
        [Display(Name="Type of Food")]
        public CuisineType Cuisine { get; set; }
    }
}
