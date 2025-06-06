using System.Text;
using OOP5_Dictionary;

Console.OutputEncoding=Encoding.UTF8;   
Category c1 = new Category();
c1.Id = 1;
c1.Name = "nước ngọt";
Product p1 = new Product();
p1.Id = 1;
p1.Name = "coca";
p1.Quantity = 10;
p1.Price = 15;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "pepsi";
p2.Quantity = 10;
p2.Price = 30;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "xá xị";
p3.Quantity = 7;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "redbull";
p4.Quantity = 30;
p4.Price = 20;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "Sprite";
p5.Quantity = 140;
p5.Price = 30;
c1.AddProduct(p5);

Console.WriteLine("-------------xuất toàn bộ-------------------");
c1.PrintAllProduct();
Console.WriteLine("--------------------------------------------");
Dictionary<int, Product> filters = c1.FillterProductByPrice(5, 100);
Console.WriteLine("cac sản phẩm giá từ 5-100");
foreach(KeyValuePair<int, Product> keyValuePair in filters)
{
    Product p = keyValuePair.Value;
    Console.WriteLine(p);
}
Dictionary<int, Product> sort_result = c1.SortProductByPrice();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("cac sản phẩm sau khi sắp xếp ");
foreach (KeyValuePair<int, Product> keyValuePair in filters)
{
    Product p = keyValuePair.Value;
    Console.WriteLine(p);
}
Console.WriteLine("--------------------------------------------");
//sắp xếp sản phẩm theo đơn giá tăng dần 
//nếu gặp đơn giá trùng nhau thì sắp xếp theo số lượng giảm dần
Dictionary <int,Product> sort_complex = c1.ComplexSort();
Console.WriteLine("cac sản phẩm sau khi sắp xếp-complex ");
foreach (KeyValuePair<int, Product> keyValuePair in filters)
{
    Product p = keyValuePair.Value;
    Console.WriteLine(p);
}
Console.WriteLine("--------------------------------------------");
p1.Name = "xá xị";
p1.Quantity = 34;
p1.Price = 30;
c1.UpdateProduct(p1);
Console.WriteLine("sản phẩm sau khi chỉnh sửa");
c1.PrintAllProduct();
Console.WriteLine("--------------------------------------------");
int Id = 3;
bool ret=c1.RemoveProduct(Id);
if (ret)
{
    Console.WriteLine($"đã xóa sản phẩm có mã {Id} thành công");
    Console.WriteLine("sản phẩm sao khi xóa");
    c1.PrintAllProduct();
    Console.WriteLine("--------------------------------------------");
}
else
{
    Console.WriteLine($"đã xóa sản phẩm có mã {Id}không thành công");
    Console.WriteLine("sản phẩm sau khi xóa");
    c1.PrintAllProduct();
    Console.WriteLine("--------------------------------------------");

}
Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia";
c2.AddProduct(new Product() { Id = 6, Name = "bia sai gon", Quantity = 35, Price = 35 });
c2.AddProduct(new Product() { Id = 7, Name = "bia 333     ", Quantity = 40, Price = 40 });
c2.AddProduct(new Product() { Id = 8, Name = "bia heinyken", Quantity = 45, Price = 45 });
c2.AddProduct(new Product() { Id = 9, Name = "bia saporo", Quantity = 50, Price = 50 });
LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c2);
ss.AddLast(c1);
Console.WriteLine("toàn bộ dữ liệu danh mục");
foreach (Category c in ss)
{
    Console.WriteLine($"--{c.Name}--");
    Console.WriteLine("--------------------------------------------");
    c.PrintAllProduct();
    Console.WriteLine("--------------------------------------------");
}    

