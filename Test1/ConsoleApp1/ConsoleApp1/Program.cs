using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[4];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write($" |{testArray[i]}| ");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------");

            for (int i = (testArray.Length - 1); i >= 0; i--)
            {
                Console.Write($" |{testArray[i]}| ");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------");

            int sumPara = 0;

            for (int i = 0; i < testArray.Length; i++)
            {

                if (testArray[i]%2 == 0)
                {
                    sumPara += testArray[i];
                }
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Parna suma = {sumPara}");
            Console.WriteLine("----------------------");

            int min = testArray[0];

            for (int i = 0; i < testArray.Length; i++)
            {
                if(min > testArray[i])
                {
                    min = testArray[i];
                }
            }

            Console.WriteLine($"Minimum = {min}");
        }
    }
}
