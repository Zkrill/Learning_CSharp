using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndArrayExecise
{
    class Program
    {
        static void resize(ref int[] array)
        {
            Console.WriteLine("Enter new size of array:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            array = null;
            array = new int[a];
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            resize(ref arr);
            Console.WriteLine();
            Console.WriteLine("New array:");
            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
