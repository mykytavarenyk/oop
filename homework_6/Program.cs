using System;
using System.Collections;

namespace homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipse ellipse1 = new Ellipse(0.1, 0.3, 1, 2);

            Ellipse ellipse2 = new Ellipse(0.7, 0.3, 3, 4);

            Console.WriteLine("Choose operation for perimeters of ellipses:\n1.Sum\n2.Division");

            Ellipse.performOperationWithPerimeters(Convert.ToInt32(Console.ReadLine()), ellipse1, ellipse2);

            Circle circle1 = new Circle(0.3, 5, 8);

            Circle circle2 = new Circle(0.7, 4, 7);

            Console.WriteLine("Choose operation for perimeters of circles:\n1.Sum\n2.Division");

            Circle.performOperationWithPerimeters(Convert.ToInt32(Console.ReadLine()), circle1, circle2);

            ArrayList list = new ArrayList() { ellipse1,ellipse2,circle1,circle2};

            foreach(CGraphicsObject graphicsObject in list)
            {
                graphicsObject.Show();
            }
        }
    }
}
