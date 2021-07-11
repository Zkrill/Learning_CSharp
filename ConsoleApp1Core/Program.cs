using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int coll = 5;
            int[,] massive = new int[row , coll];
            int[,] massive1 = new int[row, coll];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (i != j)
                    {
                        massive[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    Console.Write(massive[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < massive1.GetLength(0); i++)
            {
                for (int j = massive1.GetLength(1) - 1; j >= 0; j--)
                {
                    if (i + j != 4)
                    {
                        massive1[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < massive1.GetLength(0); i++)
            {
                for (int j = 0; j < massive1.GetLength(1); j++)
                {
                    Console.Write(massive1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(massive.GetLength(0));
            Console.WriteLine(massive.GetLength(1));
            Console.WriteLine();
            Console.WriteLine(massive1.GetLength(0));
            Console.WriteLine(massive1.GetLength(1));
        }
    }
}
