using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Class1
    {
        static string  add;
       
        public static string AccountNumber
        {
            get
            {
                return add;
            }
            set
            {
                add = value;
            }
        }
    }
}
