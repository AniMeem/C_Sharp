using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;

            while(true){
                if(Int32.TryParse(Console.ReadLine(), out num1)){
                    if(Int32.TryParse(Console.ReadLine(), out num2)){
                          Console.WriteLine(num1+num2);
                          
                    }else{
                        Console.WriteLine("Inivalid");
                    }
                }else{
                    Console.WriteLine("Inivalid");
                }

            }

            Console.ReadKey();
        }
    }
}