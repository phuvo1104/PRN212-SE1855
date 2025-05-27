using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        public void PrintInfor()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Customer id={Id}");
            Console.WriteLine($"Customer name={Name}");
            Console.WriteLine($"Customer email={Email}");
            Console.WriteLine($"Customer phone={Phone}");
            Console.WriteLine($"Customer address={Address}");
            Console.BackgroundColor= ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
