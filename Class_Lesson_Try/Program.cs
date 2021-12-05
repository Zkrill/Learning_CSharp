using System;
using ClassLibrary1;
using ClassLibrary2;

namespace Class_Lesson_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //First check method
            //
            Console.WriteLine();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your sex: ");
            string sex = Console.ReadLine();
            if (age >= 18)
            {
                Person person_1 = new Person(name, age, sex);
                person_1.printPerson();
            }
            if(age < 18)
            {
                Console.WriteLine("You are not adult, need 18 years old and more!");
            }
            //
            //Second check method
            //
            Console.WriteLine();
            Console.WriteLine();
            Human human_1 = new Human();
            Console.Write("Enter your name: ");
            human_1.Name = Console.ReadLine();
            Console.Write("Enter your age: ");
            human_1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1 if you male, enter 2 if you female");
            Console.Write("Enter your sex: ");
            human_1.Sex = Console.ReadLine();

            human_1.print_Human();
        }
    }
}
