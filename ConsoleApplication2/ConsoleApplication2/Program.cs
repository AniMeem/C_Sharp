using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num, num1;
            int x;
            num = Console.ReadLine();
            num1 = Console.ReadLine();
            int a = Convert.ToInt32(num);
            int b = Convert.ToInt32(num1);
            int c = a + b;
            int d = a * b;
            int e = a / b;
            int f = a - b;
            Console.WriteLine("Add:" + c);
            Console.WriteLine("multi:" + d);
            Console.WriteLine("div:" + e);
            Console.WriteLine("sub:" + f);

            Console.ReadKey();
        }
    }
}
