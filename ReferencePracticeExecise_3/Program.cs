using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencePracticeExecise_3
{
    class Program
    {
        static void delFromBegin(ref int[] array)
        {
            int[] arr = array;
            array = null;
            array = new int[arr.Length - 1];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i + 1];
            }
        }

        static void delFromEnd(ref int[] array)
        {
            int[] arr = array;
            array = null;
            array = new int[arr.Length - 1];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i];
            }
        }

        static void delFromIndex(ref int[] array)
        {
            Console.Write("Enter index of element to delete: ");
            int index = int.Parse(Console.ReadLine());
            int[] arr = array;
            array = null;
            array = new int[arr.Length - 1];
            for(int i = 0; i < arr.Length; i++)
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
                    array[i - 1] = arr[i];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arrayNum = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.Write(arrayNum[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter 1 to delete first element");
            Console.WriteLine("Enter 2 to delete element in the end");
            Console.WriteLine("Enter 3 to delete element from index");
            int chose = int.Parse(Console.ReadLine());
            if (chose == 1)
            {
                delFromBegin(ref arrayNum);
                for (int i = 0; i < arrayNum.Length; i++)
                {
                    Console.Write(arrayNum[i] + " ");
                }
            }
            if (chose == 2)
            {
                delFromEnd(ref arrayNum);
                for(int i = 0; i < arrayNum.Length; i++)
                {
                    Console.Write(arrayNum[i] + " ");
                }
            }
            if (chose == 3)
            {
                delFromIndex(ref arrayNum);
                for(int i = 0; i < arrayNum.Length; i++)
                {
                    Console.Write(arrayNum[i] + " ");
                }
            }
        }
    }
}
