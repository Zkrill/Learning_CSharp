using System;

namespace InheritanceClass
{
    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private string sex;
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if(value == "Male" || value == "male" || value == "Female" || value == "female")
                {
                    sex = value;
                }
                else
                {
                    Console.WriteLine("Unknown sex");
                    sex = "Unknown";
                }
            }
        }

        public Person(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
    }

    public class Employee : Person
    {
        private string company;
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        private string position;
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = Convert.ToDecimal(value);
            }
        }

        public Employee(string name, int age, string sex, string company, string position, decimal salary): base(name, age, sex)
        {
            Company = company;
            Position = position;
            Salary = salary;
        }

        public void print_info()
        {
            Console.WriteLine($"Employee name is {Name}, {Age} years old, sex {Sex}, work in {company}, position is {Position}, have {Salary} salary.");
        }
    }
}
