using System.Text;
using DemoLinQToObject2;

Console.OutputEncoding=Encoding.UTF8;
ListProduct lp=new ListProduct();
lp.gen_products();
// câu 1 lọc ra các sản phẩm có giá từ a đén b
// sử dụng method syntax và query syntax
var result1 = lp.FilterProductByPrice(10, 20);
Console.WriteLine("Sản phẩm có giá từ 10 đến 20 (method syntax):");
result1.ForEach(x => Console.WriteLine(x));

// Query syntax
var result2 = lp.FilterProductByPrice2(10, 20);
Console.WriteLine("\nSản phẩm có giá từ 10 đến 20 (query syntax):");
result2.ForEach(x => Console.WriteLine(x));

// câu 2 sắp xếp các sản phẩm giảm dần 
