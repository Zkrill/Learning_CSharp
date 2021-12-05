using System;

namespace TestApp
{
    struct Num
    {
        public int i;
    }
    class MyProgram
    {
        static void Main()
        {
            Num x = new Num();
            x.i = 10;
            Update(ref x);
            Console.Write(x.i);
        }

        static void Update(ref Num y)
        {
            y.i = 20;
        }
    }
}
