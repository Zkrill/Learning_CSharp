using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLesson
{
    class Program
    {
        static string inputSymbol()
        {
            Console.WriteLine("Введите символ:");
            string symbol = Console.ReadLine();
            return symbol;
        }

        static int inputCount()
        {
            Console.WriteLine("Введите количество вивода:");
            int count = int.Parse(Console.ReadLine());
            return count;
        }

        static void writeSymbol(string symb, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(symb + " ");
            }
        }

        static void Main(string[] args)
        {
            writeSymbol(inputSymbol(), inputCount());
        }
    }
}
