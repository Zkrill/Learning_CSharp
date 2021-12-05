using System;

namespace RecursionPractice_ex3
{

    class Program
    {
        static void charNumSum(in char[] num, int i = 0, int result = 0)
        {
            if (i == num.Length)
            {
                Console.WriteLine("The sum is " + result);
                return;
            }
            result += int.Parse(num[i].ToString());
            i++;
            charNumSum(in num, i, result);
        }
        static void Main(string[] args)
        {
            char[] a = {'5', '6', '1'}; // = 12
            charNumSum(in a);
        }
    }
}
