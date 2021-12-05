using System;
using InheritanceClass;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string sex;
            string company;
            string position;
            decimal salary;

            enter_Info(out name, out age, out sex, out company, out position, out salary);

            Employee work1 = new Employee(name, age, sex, company, position, salary);

            work1.print_info();
        }

        static void enter_Info(out string name, out int age, out string sex, out string company, out string position, out decimal salary)
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sex:");
            sex = Console.ReadLine();
            Console.WriteLine("Enter company:");
            company = Console.ReadLine();
            Console.WriteLine("Enter position:");
            position = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            salary = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
