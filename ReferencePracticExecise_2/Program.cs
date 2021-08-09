using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencePracticExecise_2
{
    class Program
    {
        static void addElementInStart(ref int[] array)
        {
            Console.Write("Enter element: ");
            int element = int.Parse(Console.ReadLine());
            int[] arr = array;
            array = null;
            array = new int[arr.Length + 1];
            array[0] = element;
            for(int i = 1; i < array.Length; i++)
            {
                array[i] = arr[i - 1];
            }
        }

        static void addElementInEnd(ref int[] array)
        {
            Console.Write("Enter element: ");
            int element = int.Parse(Console.ReadLine());
            int[] arr = array;
            array = null;
            array = new int[arr.Length + 1];
            array[arr.Length] = element;
            for(int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
        }

        static void addElementInIndex(ref int[] array)
        {
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter element: ");
            int element = int.Parse(Console.ReadLine());
            int[] arr = array;
            array = null;
            array = new int[arr.Length + 1];
            array[index] = element;
            for(int i = 0; i < array.Length; i++)
            {
                if(i == index)
                {
                    continue;
                }
                if(i < index)
                {
                    array[i] = arr[i];
                }
                if(i > index)
                {
                    array[i] = arr[i-1];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach(int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter 1 to add one element were array is start");
            Console.WriteLine("Enter 2 to add one element were array is end");
            Console.WriteLine("Enter 3 to add one element were you want");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(a == 1)
            {
                addElementInStart(ref arr);
                foreach(int item in arr)
                {
                    Console.Write(item + " ");
                }
            }
            else if(a == 2)
            {
                addElementInEnd(ref arr);
                foreach(int item in arr)
                {
                    Console.Write(item + " ");
                }
            }
            else if(a == 3)
            {
                addElementInIndex(ref arr);
                foreach(int item in arr)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Unknown command!!!");
            }
        }
    }
}
