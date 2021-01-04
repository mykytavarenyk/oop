using System;
using static System.Math;
namespace homework_6
{
    interface IEllipsePerimeter
    {
        double Perimeter();
    }

    public class Ellipse : CGraphicsObject,IEllipsePerimeter
    {
        private double a;//первая полуось эллипса

        private double b;//вторая полуось эллипса

        delegate double Operation(Ellipse operand1, Ellipse operand2);

        public Ellipse(double a,double b,int x,int y)
        {
            this.a = a;

            this.b = b;

            point.X = x;

            point.Y = y;
        }

        ~Ellipse()
        {

        }

        public double A
        {
            get { return a; }

            set { a = value; }
        }

        public double B
        {
            get { return b; }

            set { b = value; }
        }

        public double Perimeter()
        {
            return PI * Sqrt(2 * (Pow(A, 2) + Pow(B, 2)));
        }

        public static void performOperationWithPerimeters(int operationType, Ellipse operand1, Ellipse operand2)
        {
            Operation operation;

            if(operationType == 1)
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

        private static double Sum(Ellipse operand1, Ellipse operand2)
        {
            return operand1.Perimeter() + operand2.Perimeter();
        }

        private static double Division(Ellipse operand1, Ellipse operand2)
        {
            return operand1.Perimeter() / operand2.Perimeter();
        }

        public override void Show()
        {
            Console.WriteLine("Perimeter=" + Perimeter() + ", A=" + A + ", B=" + B + ", X=" + point.X + ", Y=" + point.Y);
        }
    }
}