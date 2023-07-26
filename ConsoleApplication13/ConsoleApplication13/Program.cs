using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>(5);
            //List<string> lists=new List<string>();
            //ArrayList numbers=new ArrayList(3);
            ////numbers[0] = 1;
            numbers.Add(12);
            numbers.Add(15);
            numbers.Add(100);
            numbers.Add(203);
            numbers.Add(99);

            foreach(int n in numbers){
                Console.WriteLine(n);
            }

            Console.WriteLine();

            numbers.Remove(15);

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
