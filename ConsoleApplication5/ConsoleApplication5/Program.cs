using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            double i, j, total;
            i = Convert.ToDouble(Console.ReadLine());
            j = Convert.ToDouble(Console.ReadLine());   
            i = (int)i;
            j = (int)j;

           total = i + j;

           Console.WriteLine(total);
           
           Console.ReadKey();
        }
    }
}
