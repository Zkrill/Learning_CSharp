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
            int[][] teathArray = new int[3][];

            Random random = new Random();

            teathArray[0] = new int[4];
            teathArray[1] = new int[2];
            teathArray[2] = new int[6];

            for (int i = 0; i < teathArray.Length; i++)
            {
                for(int j = 0; j < teathArray[i].Length; j++)
                {
                    teathArray[i][j] = random.Next(100);
                    Console.Write(teathArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
