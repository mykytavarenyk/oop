using System;

namespace homework_2
{
    class Hexagon
    {
        private double sideLength;

        public double GetSideLength()
        {
            return sideLength;
        }

        public void SetSideLength(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public double CalculateArea()
        {
            return (Math.Pow(sideLength, 2) * 3 * Math.Sqrt(3) / 2);
        }

        public Hexagon(double sideLength)
        {
            this.sideLength = sideLength;
        }

        ~Hexagon()
        {
            Console.WriteLine("Hexagon destroyed");
        }
    }
}
