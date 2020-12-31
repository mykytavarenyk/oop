using System;

namespace homework_2
{
    class Runner
    {
        static void Main(string[] args)
        {
            Hexagon hexagon = new Hexagon(3);

            Console.WriteLine("Площа правильного шестикутнику :" + hexagon.CalculateArea());

            hexagon.SetSideLength(7);

            Console.WriteLine("Площа правильного шестикутнику :" + hexagon.CalculateArea());

            Console.WriteLine("Сторона правильного шестикутнику :" + hexagon.GetSideLength());
        }
    }
}
