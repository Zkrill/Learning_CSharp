using System;

namespace ClassLibrary1
{
    public class Person
    {
        private string name;
        private int age;
        private string sex;
        /// <summary>
        /// This constrator have 4 reload||
        /// Person without parameters||
        /// Person with 1 parameter (string name)||
        /// Person with 2 parameters (string name, int age)||
        /// Person with 3 parameters (string name, int age, string sex)||
        /// For every parameters are standart value, for string it's "Unknown" , for num it's "0"||
        /// </summary>
        public Person() : this("Unknown", 0, "Unknown")
        {
        }
        
        public Person(string name) : this(name , 0 , "Unknown")
        {
        }
        
        public Person(string name, int age) : this(name, age, "Unknown")
        {
        }
        
        public Person(string name, int age , string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public void printPerson()
        {
            Console.WriteLine($"Name = {name} | Age = {age} | Sex = {sex}");
        }
    }
}
