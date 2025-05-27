//đề tài 
//* nhập vào 1 số >= 0 nhập sai quy tắc 
//    * thì yêu câu lại khi nào đúng mới dừng
//    *nếu nhập đúng thì tính giai thừa của số này
//    */
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
int n=-1;
while (n <0)
{
    Console.WriteLine("nhập n>=0");
    string input=Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    { // khi vào đây n là số , nhưng có thẻ nhỏ hơn 0
        if (n >= 0)//nhập đúng 
            break;// không , bắt nhập lại
        else
            Console.WriteLine("tui đã nói nhập >=0 mà");
    }
    else 
    {
        Console.WriteLine("Lựu đạn quá cha ");
    }
}
int gt = 1;
for(int i = 1; i < n; i++)
    gt = gt *i;
Console.WriteLine($"{n}!={gt}");