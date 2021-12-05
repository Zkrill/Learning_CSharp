using System;

namespace ClassLibrary2
{
    public class Human
    {
        private string name = "Unknown";

        public string Name
        {
            private get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int age = 0;

        public int Age
        {
            private get
            {
                return age;
            }
            
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
                if (value < 18)
                {
                    Console.WriteLine("You are not adult, need 18 years old and more!");
                }
            }
        }

        private string sex = "Unknown";

        public string Sex
        {
            private get
            {
                return sex;
            }

            set
            {
                int temp = int.Parse(value);
                if(temp == 1)
                {
                    sex = "male";
                }
                else if(temp == 2)
                {
                    sex = "female";
                }
                else
                {
                    sex = "Unknown sex!";
                }
            }
        }

        public void print_Human()
        {
            if(age < 18)
            {
                return;
            }
            Console.WriteLine($"Name is {name} | Age = {age} | Sex is {sex}");
        }

    }
}
