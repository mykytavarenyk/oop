using System;
using static System.Math;

namespace homework_6
{
    interface ICirclePerimeter
    {
        double Perimeter();
    }
    public class Circle : CGraphicsObject,ICirclePerimeter
    {
        private double radius;

        delegate double Operation(Circle operand1, Circle operand2);

        public Circle(double radius,int x,int y)
        {
            this.radius = radius;

            point.X = x;

            point.Y = y;
        }

        ~Circle()
        {

        }

        public double Radius // радиус окружности
        {
            get { return radius; }

            set { radius = value; }
        }

        public static void performOperationWithPerimeters(int operationType,Circle operand1,Circle operand2)
        {
            Operation operation;

            if (operationType == 1)
            {
                operation = Sum;
                Console.WriteLine("Sum of perimeters:" + operation(operand1, operand2));
            }
            else
            {
                operation = Division;
                Console.WriteLine("Division of perimeters:" + operation(operand1, operand2));
            }
        }

        private static double Sum(Circle operand1, Circle operand2)
        {
            return operand1.Perimeter() + operand2.Perimeter();
        }

        private static double Division(Circle operand1, Circle operand2)
        {
            return operand1.Perimeter() / operand2.Perimeter();
        }

        public double Perimeter()
        {
            return 2 * PI * Radius;
        }

        public override void Show()
        {
            Console.WriteLine("Perimeter=" + Perimeter() + ", R=" + Radius + "X=" + point.X + ", Y=" + point.Y);
        }
    }
}