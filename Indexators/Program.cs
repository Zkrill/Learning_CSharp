using System;
using ClassIndexators;

namespace Indexators
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(3);

            car[0] = new Light_Car();
            car[0].Firm = "Mersedes";
            car[0].Model = "Ochkarik";
            car[0].People_in = 5;

            car[1] = new Light_Car();
            car[1].Firm = "Lada";
            car[1].Model = "2109";
            car[1].People_in = 6;

            car[2] = new Light_Car();
            car[2].Firm = "Lanus";
            car[2].Model = "Sedan";
            car[2].People_in = 4;

            car[0].print_Car();
            Console.WriteLine();
            car[1].print_Car();
            Console.WriteLine();
            car[2].print_Car();
        }
    }
}
