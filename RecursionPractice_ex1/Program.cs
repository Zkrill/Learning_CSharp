using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractice_ex1
{
    class Program
    {
        static void arrayPrint(in int[] arr , int i)
        {
            if(i == arr.Length)
            {
                return;
            }
            Console.Write(arr[i] + " ");
            i++;
            arrayPrint(in arr , i);
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            arrayPrint(in array, 0);
        }
    }
}
