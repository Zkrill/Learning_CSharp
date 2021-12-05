using System;

namespace ClassIndexators
{
    public class Light_Car
    {
        private string firm;
        public string Firm
        {
            get { return firm; }
            set { firm = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int people_in;
        public int People_in
        {
            get { return people_in; }
            set { people_in = value; }
        }
        public void print_Car()
        {
            Console.WriteLine($"{firm} {model} can transport {people_in} people.");
        }

    }

    public class Car
    { 
        private Light_Car[] lCar;

        public Car(int arrayLenght)
        {
            lCar = new Light_Car[arrayLenght];
        }

        public Light_Car this[int index]
        {
            get
            {
                return lCar[index];
            }
            set
            {
                lCar[index] = value;
            }
        }
    }
}
