using System.Text;

namespace FullStrctureProject; 

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Cha mẹ \"thói đời\" ăn ở bạc");
        Console.WriteLine("Có chồng cà chớn cũng như không ");
        for (int i = 0; i < args.Length; i++)
        {

            Console.WriteLine(args[i]);
        }
        Console.ReadLine();
    }
}