using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse_as_Library
{
    public static class YourUtils
    {
        public static int TinhTuoi(this Employees emp)
        {
            return DateTime.Now.Year - emp.BirthDay.Year;
        }
    }
}
