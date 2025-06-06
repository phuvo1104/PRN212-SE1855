using System.Diagnostics;
using System.Text;

using DemoAliasAndClone;
Console.OutputEncoding=Encoding.UTF8;
Student s1 = new Student();
s1.Id = 1;
s1.Name = "Trần Thị Tèo";

Student s2 = new Student();
s2.Id = 2;
s2.Name = "Trần Thị Tèo";
s1 = s2;
//lúc này trên thanh ram sẻ cấp phát 2 bộ nhớ
//cho s1 quản lý s2
//s1 đổi giá trị ko liên QUAN j đến s2
//vì s1 s2 đang quản lý 2 ô nhớ khác nhau
// ta viết lệnh s1=s2
//tuy nhiên về bản chất nó hoạt động như sau
//s1 trỏ tới vùng nhớ mà s2 đang quản lý
//chứ ko phải s1=s2
//có 2tinhf huống như sau
//(1)ô nhớ bên s2 giờ có thêm s1 quản lý ==> alias =>2 đối tượng quản lý
//chỉ cần 1 đối tượng thì các đối tượng khác đều bị đổi
//
s2.Name = "nguyễn thị Lung Linh";
Console.WriteLine("s1 đổi tên vậy s2 tên là gì");

Console.WriteLine(s1);
//2 ô nhớ lúc trước s1 đang quản lý giờ ko còn đối tượng nào quản lý
//thì lúc này HđH tự dộng thu hồi ô nhớ Automatic gabarge collection

Product p1= new Product()
{ Id = 1,Name = "p1", Quantity = 1,Price = 20};
Product p2 = new Product()
{ Id = 2,Name = "p2", Quantity = 1,Price = 20};
Product p3 = new Product()
{ Id = 3, Name = "p3", Quantity = 1, Price = 20 };
Product p4 = new Product()
{ Id = 4, Name = "p4", Quantity = 1, Price = 20 };

Product p5 = p3;
p3 = p4;
Product p6 = p4.Clone( );

Console.WriteLine("dữ liệu pruduct 6");
Console.WriteLine(p6);
Console.WriteLine("dữ liệu product 4");
Console.WriteLine(p4);
p4.Name = "THUỐC TRỊ XÀM ";
Console.WriteLine("dữ liệu pruduct 6");
Console.WriteLine(p6);
Console.WriteLine("dữ liệu product 4");
Console.WriteLine(p4);