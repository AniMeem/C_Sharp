using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                   if((col+row) % 2 == 0){
                       Console.Write("X");
                   }
                   else if ((col + row) % 2 == 1)
                   {
                       Console.Write("O");

                   }else{
                       Console.Write("neither X nor O");
                   }
                }
                
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
