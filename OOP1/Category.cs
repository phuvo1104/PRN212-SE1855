using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }

        public void PrintInfor()
        {
            Console.WriteLine($"{id}\t{name}");
        }
    }
}
