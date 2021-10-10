using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMoney show = Dollar;
            Console.WriteLine(show(156.32));
            show = Euro;
            Console.WriteLine(show(156.32));

            Console.ReadLine();
        }

        public delegate string ShowMoney(double x);

        public static string Dollar(double x)
        {
            return $" Vous avez {x} dollars";
        }

        public static string Euro(double x)
        {
            return $" Vous avez {x} euros";
        }
        
        
    }
}
