using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{

    class Calculator
    {

        public static bool isEqual<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

  
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine( Calculator.isEqual<int>(3, 3));

         Console.WriteLine( Calculator.isEqual<double>(3.4, 3.6));

         Console.ReadKey();
        }
    }
}
