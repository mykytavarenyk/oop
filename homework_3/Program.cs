using System;

namespace homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Toroid toroid = new Toroid(3,7);

            toroid.BigRadius = 3;

            toroid.SmallRadius = 7;

            Console.WriteLine(toroid.Show());

        }
    }
}
