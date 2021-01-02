using System;

namespace homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            VehicleImpl impl = new VehicleImpl();

            string result;
            
            if(random.Next(2) == 1)
            {
                result = ((ITank) impl).Move();
            }
            else
            {
                result = ((IShip)impl).Move();
            }

            Console.WriteLine(result);
        }
    }
}
