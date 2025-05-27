using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Phương trình bậc 2: ax^2 + bx + c = 0");

        Console.Write("Hệ số a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Hệ số b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Hệ số c: ");
        double c = double.Parse(Console.ReadLine());

        QuadraticEquationSolution(a, b, c);

        Console.ReadLine();
    }

    static void FirstDegreeSolution(double a, double b)
    {
        if (a == 0 && b == 0)
        {
            Console.WriteLine("Phương trình có vô số nghiệm.");
        }
        else if (a == 0 && b != 0)
        {
            Console.WriteLine("Phương trình vô nghiệm.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Nghiệm của phương trình là x = {x}");
        }
    }

    static void QuadraticEquationSolution(double a, double b, double c)
    {
        if (a == 0)
        {
            FirstDegreeSolution(b, c);
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm (không có nghiệm thực).");
            }
        }
    }
}
