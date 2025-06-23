using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
namespace DataAccessLayer
{
    public class ProductDAO
    {
        static LinkedList<Product> list = new List<Product>();
        public void GenerateSampleDataSet()
        {
            products.Add(new Product() { Id = 1, Name = "coca", Quantity = 10, Price = 1000 });
            products.Add(new Product() { Id = 2, Name = "coca", Quantity = 10, Price = 1000 });
            products.Add(new Product() { Id = 3, Name = "coca", Quantity = 10, Price = 1000 });
            products.Add(new Product() { Id = 4, Name = "coca", Quantity = 10, Price = 1000 });
            products.Add(new Product() { Id = 5, Name = "coca", Quantity = 10, Price = 1000 });

        }
        public List<Product> GetProducts
        {
            return products;
        }
    }
