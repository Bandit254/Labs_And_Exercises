using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

namespace ISTA322___20200314___ZSilvis___LAB_9C__Working_with_Visual_Studio_.Models
{
    public class SimpleRepository
    {
        public static SimpleRepository SharedRepository = new SimpleRepository();
        public Dictionary<string, Product> products = new Dictionary<string, Product>();

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name = "Kayak", Price = 275M },
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer Ball",Price = 19.50M},
                new Product {Name = "Corner Flag", Price = 34.95M}
            };

            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);
        }

        public IEnumerable<Product> Products => products.Values;

        public void AddProduct(Product p) => products.Add(p.Name, p);
	

    }
}
