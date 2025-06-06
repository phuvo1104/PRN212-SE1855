using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQToObject2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_products()
        {
            products.Add(new Product() { Id = 1, Name = "p1", Quantity = 11, Price = 11 });
            products.Add(new Product() { Id = 2, Name = "p2", Quantity = 12, Price = 12 });
            products.Add(new Product() { Id = 3, Name = "p3", Quantity = 13, Price = 13 });
            products.Add(new Product() { Id = 4, Name = "p4", Quantity = 14, Price = 14 });
            products.Add(new Product() { Id = 5, Name = "p5", Quantity = 15, Price = 15 });
            products.Add(new Product() { Id = 6, Name = "p6", Quantity = 16, Price = 16 });
            products.Add(new Product() { Id = 7, Name = "p7", Quantity = 17, Price = 17 });
            products.Add(new Product() { Id = 8, Name = "p8", Quantity = 18, Price = 18 });
            products.Add(new Product() { Id = 9, Name = "p9", Quantity = 19, Price = 19 });
            products.Add(new Product() { Id = 10, Name = "p10", Quantity = 20, Price = 20 });
            products.Add(new Product() { Id = 11, Name = "p11", Quantity = 21, Price = 21 });
        }
        public List<Product> FilterProductByPrice(double price1, double price2)
        {
            return products
                .Where(p => p.Price == price1 && p.Price <= price2)
                .ToList();

        }

        public List<Product> FilterProductByPrice2(double price1, double price2)
        {
            var results = (from p in products
                           where p.Price >= price1 && p.Price <= price2
                           select p).ToList();  // query syntax

            return results;
        }
        public List<Product> SortProductByPriceDesc()
        {
            return products
                .OrderByDescending(p => p.Price)
                .ToList();

        }
        public List<Product> SortProductByPriceAsc2()
        {
            var result = from p in products
                         orderby p.Price descending
                         select p;
            return result.ToList();

        }
        public double SumOfValue()
        { 
        return products.Sum(p => p.Quantity*p.Price);
        }

    }
}
