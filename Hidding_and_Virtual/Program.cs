using System;
using ClassLibrary;

namespace Hidding_and_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Vasia", "Ivanuhovich", 25);
            Citizen citizen = new Citizen("Kolia", "Novikov", 19, 452, "AD4C2ddgxY4x2");

            human.display();

            citizen.display();

            Console.WriteLine();

            human.setInfo();

            Console.WriteLine();

            citizen.setInfo();

            Console.WriteLine();

            human.display();

            citizen.display();
        }
    }
}
