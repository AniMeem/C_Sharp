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

            for (int col = 0; col > 8; col++ )
            {
                for (int row = 0; row > 4; row++ )
                {
                    Console.WriteLine("a-",row);
                    /*
                    if( (col + row) % 2 == 0 ){
                        Console.WriteLine("X");
                    }
                    else if ((col + row) % 2 == 1)
                    {
                        Console.WriteLine("O");
                    }
                    else
                    {
                        Console.WriteLine("neither X or O");
                    }
                      
                     */

                }
                Console.WriteLine();
            }

     Console.ReadKey();

        }
    }
}
