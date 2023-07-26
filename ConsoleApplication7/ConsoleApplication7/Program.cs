using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {

        static void print(int[][] arr)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                        Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
             }
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][] {
                         new int[]{12, 15, 17, 66},
                           new int[]{33, 90, 81, 11},
                             new int[]{54, 35, 40, 13}
                          };
  

            print(arr);
            Console.Write("Enter index i of Jagged Array that you want to change: ");

            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter index j of Jagged Array that you want to change: ");

            int column = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number you want to replace with: ");
            int value = Convert.ToInt32(Console.ReadLine());
            arr[row][column] = value;

            Console.WriteLine("Data chnaged, Exiting...");
            print(arr);
            
            Console.ReadKey();
        }
    }
}
