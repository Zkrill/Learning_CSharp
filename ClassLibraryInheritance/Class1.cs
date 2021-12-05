using System;

namespace ClassLibraryInheritance
{
    public class Auto
    {
        private string model;
        public string Model { get; set; }

        protected int passengers;
        public virtual int Passengers
        {
            get
            {
                return passengers;
            }
            set
            {
                if(value > 5)
                {
                    Console.WriteLine("Cannot be more than 5!");
                    passengers = 5;
                }
                else
                {
                    passengers = value;
                }
            }
        }

        public Auto (string model, int passengers)
        {
            Model = model;
            Passengers = passengers;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Auto {Model} can transport {Passengers} peoples");
        }
    }

    public class Track : Auto
    {
        private double transportHeight;
        public double TransportHeight
        {
            get
            {
                return transportHeight;
            }
            set
            {
                if(value > 1000)
                {
                    Console.WriteLine("Track cannot transport this height!");
                    transportHeight = 1000;
                }
                else
                {
                    transportHeight = value;
                }
            }
        }
        public override int Passengers 
        {
            get
            {
                return passengers;
            }
            set
            {
                if(value > 3)
                {
                    Console.WriteLine($"Track cannot transport more that 3 people!");
                    passengers = 3;
                }
                else
                {
                    passengers = value;
                }
            }
        }

        public Track(string model, int passengers, double transportHeight) : base(model, passengers)
        {
            TransportHeight = transportHeight;
        }

        public override void Display()
        {
            Console.WriteLine($"Track {Model} can transport {TransportHeight} and {Passengers} peoples");
        }
    }

    public class Bus : Auto
    {
        public Bus(string model, int passengers): base(model, passengers)
        { }

        public override int Passengers
        {
            get
            {
                return passengers;
            }
            set
            {
                if (value > 50)
                {
                    Console.WriteLine("Bus cannot transport more than 50 passengers!");
                    passengers = 50;
                }
                else
                {
                    passengers = value;
                }

            }
        }

        public override void Display()
        {
            Console.WriteLine($"Bus {Model} can transport {Passengers} peoples");
        }
    }
}
