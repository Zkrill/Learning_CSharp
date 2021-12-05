using System;

namespace ClassLibrary
{
    public class Human
    {
        private string name;
        private string secondName;
        private int age;

        protected string Name
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

        protected string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                secondName = value;
            }
        }

        protected int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public Human (string name, string secondName, int age)
        {
            Name = name;
            SecondName = secondName;
            Age = age;
        }

        public void display()
        {
            Console.WriteLine($"{Name} {SecondName} is {Age} years old.");
        }

        public virtual void setInfo()
        {
            Console.Write("Enter a name: ");
            Name = Console.ReadLine();
            Console.Write("Enter a second name: ");
            SecondName = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
        }
    }

    public class Citizen : Human
    {
        private int id;
        private string passportCode;

        protected int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        
        protected string PassportCode
        {
            get
            {
                return passportCode;
            }
            set
            {
                passportCode = value;
            }
        }

        public Citizen(string name, string secondName, int age, int id, string passportCode) : base(name, secondName, age)
        {
            Id = id;
            PassportCode = passportCode;
        }

        public new void display()
        {
            Console.WriteLine($"{Name} {SecondName} {Age} years old have ID = {Id} and passport code \"{passportCode}\" ");
        }

        public override void setInfo()
        {
            base.setInfo();
            Console.Write("Enter id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter passport code: ");
            PassportCode = Console.ReadLine();
        }
    }
}
