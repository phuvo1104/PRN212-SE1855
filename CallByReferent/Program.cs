using System.Text;

void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong hàm ={n}");

}
Console.OutputEncoding=Encoding.UTF8;
int n = 5;
Console.WriteLine($"n trước khi vào hàm ={n}");
ham1(n);
Console.WriteLine($"n sau khi vào hàm ={n}");

void ham2 (ref int n)
 {
        n = 8;
Console.WriteLine($"n trong hàm ={n}");
}
Console.WriteLine($"-------REF-------");
n = 5;
Console.WriteLine($"n trước khi vào hàm ={n}");
ham2(ref n);
Console.WriteLine($"n sau khi vào hàm ={n}");
int m;
ham2 (ref m);

//ref phải khởi tạo giá trị trc khi gọi
//int m;
//hàm ham2(ref m) báo lỗi vì dòn 24 chưa có giá trị truyền vào

void ham3(out int n)
{
    n=8;

}