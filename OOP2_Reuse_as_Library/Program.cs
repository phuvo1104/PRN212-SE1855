using System.Text;
using OOP2;
using OOP2_Reuse_as_Library;

Console.OutputEncoding =Encoding.UTF8;
FullTimeEmployees e1 = new FullTimeEmployees();
e1.Id = 1;
e1.Name = "teo";
e1.IdCard = "123";
e1.BirthDay = new DateTime(1990, 12, 25);
Console.WriteLine("--------thong tin e1------");
Console.WriteLine(e1);
Console.WriteLine("==> AGE: " + e1.TinhTuoi());
