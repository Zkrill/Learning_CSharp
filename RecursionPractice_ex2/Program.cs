using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractice_ex2
{
    class Program
    {
        static void ArraySum(in int[] arr, int i = 0 , int result = 0)
        {
            if (i == arr.Length)
            {
                Console.WriteLine("Array sum: " + result);
                return;
            }
            result += arr[i];
            i++;
            ArraySum(in arr, i, result);
            
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // = 45
            ArraySum(in array);
        }
    }
}
