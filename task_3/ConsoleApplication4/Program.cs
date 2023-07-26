using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4] { "Meem", "Anika", "Anjum", "Tumpa" };
            foreach (string a in arr)
            {
                Console.WriteLine(a + " ");
            }

            Console.ReadKey();
        }
    }
}
