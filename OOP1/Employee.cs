using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        #region contructor
        public int id ;
        public string idCard;
        public string name;
        public string email;
        public string phone;
        #endregion
        #region

        public Employee() { 
        
        }
    
        public void PrintInfor()
        {
            string msg = $"{id}\t{idCard}\t{name}\t{email}\t{phone}";
            Console.WriteLine(msg);
        }
        public Employee(int id, string idCard, string name, string email, string phone)
        {
            
            this.id = id ;
            this.idCard = idCard ;
            this.name = name ;
            this.email = email ;
            this.phone = phone ;
                
        }
        #endregion
        #region tostring
        public override string ToString()
        {
            String msg = $"{id}\t{idCard}\t{name}\t{email}\t{phone}\t";
            Console.WriteLine(msg);
            return msg;
        }
        #endregion
    }
}
