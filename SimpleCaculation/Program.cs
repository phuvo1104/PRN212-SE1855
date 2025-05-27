using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;

void do_calculate(double a,double b, string op)
{
    switch(op)
    {
        case "+":
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            break;
        case "-":
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            break;
        default:
            Console.WriteLine("nhập lụi à");
            break;
    }
}
Console.WriteLine("SIMPLE CALCULATION!!");
Console.WriteLine(" nhập số a:");
double a= Double.Parse(Console.ReadLine());
Console.WriteLine(" nhập số b:");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("nhập phép toán (+,-,*,/):");
string op = Console.ReadLine();
do_calculate(a,b,op);
Console.ReadLine();