using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionLesson_Task_2
{
    class Program
    {

        static int itemForSearch()
        {
            Console.WriteLine("Enter num for search:");
            int item = int.Parse(Console.ReadLine());
            return item;
        }

        static int[,] randomArray()
        {
            int[,] arrayR = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j ++)
                {
                    arrayR[i , j] = random.Next(11);
                }
            }
            return arrayR;
        }

        static void searchIndex(int[,] array, int item)
        {
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i , j] == item)
                    {
                        temp1 = i;
                        temp2 = j;
                        Console.WriteLine("Значение " + item + " находится по координатам: x = " + j + "| y = " + i);
                        break;
                    }
                }
                if (array[i , temp2] == item) { break; }
            }
            if (array[temp1, temp2] != item)
            {
                Console.WriteLine("Даное значение не входит в массив!");
            }
        }

        static void Main(string[] args)
        {
            searchIndex(randomArray(), itemForSearch());
            int[] myArray;
            myArray ??= new int[5];
            foreach(int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
