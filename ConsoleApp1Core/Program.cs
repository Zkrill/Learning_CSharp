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
            int[][] tearthArray = new int[3][];

            Random random = new Random();

            tearthArray[0] = new int[4];
            tearthArray[1] = new int[2];
            tearthArray[2] = new int[6];

            for (int i = 0; i < tearthArray.Length; i++)
            {
                for(int j = 0; j < tearthArray[i].Length; j++)
                {
                    tearthArray[i][j] = random.Next(100);
                    Console.Write(tearthArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
