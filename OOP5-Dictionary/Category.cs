using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();

        }
        /*
         * mọi dữ liệu ta cần làm đủ cdur
         * 
         */
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
                return;

            }
            Products.Add(p.Id, p);
        }
        public void PrintAllProduct()
        {
            foreach (KeyValuePair<int, Product> item in Products) {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }
        //lọc ra các sản phẩm có giá từ x đến y
        public Dictionary<int,Product>
            FillterProductByPrice(double min, double max)
        {
            Dictionary <int,Product> results = new Dictionary<int,Product>();
            results = Products
                .Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary(item => item.Key, item => item.Value);

            return results;
        }
        // sắp xếp sản phẩm thepo giá tăng dần 
        public Dictionary<int ,Product> SortProductByPrice()
        {
            return Products
                .OrderBy(item =>item.Value.Price)
                .ToDictionary<int,Product>();
                
        }
        public Dictionary<int, Product> ComplexSort()
        {

            return Products.OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int,Product>();
        }
        public bool UpdateProduct(Product p)
        {
            if (p == null) return false;

            if (!Products.ContainsKey(p.Id))
                return false;

            Products[p.Id] = p;
            return true;
        }
        public bool RemoveProduct(int Id)
        {
            if (!Products.ContainsKey(Id)) return false;
            return Products.Remove(Id);
        }
    }
}