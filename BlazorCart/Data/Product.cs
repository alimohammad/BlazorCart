using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCart.Data
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
