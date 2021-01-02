using System.Drawing;
using System.Windows.Forms;
using static System.Math;

namespace homework_4
{
    public class Ellipse : CGraphicsObject
    {
        private double a;//первая полуось эллипса

        private double b;//вторая полуось эллипса

        public Ellipse(double a, double b, int x, int y)
        {
            this.a = a;

            this.b = b;

            point = new Point(x, y);
        }

        ~Ellipse()
        {

        }

        public double A //первая полуось эллипса
        {
            get { return a; }

            set { a = value; }
        }

        public override void Show(Label label)
        {
            label.Text = GetClassName() + ": \nA=" + A + "\nB=" + B + "\nPerimeter=" + Perimeter() + "\n";
        }

        public override void Draw(Graphics graphics)
        {
            // using (Pen pen = new Pen(Color.Black))
            //{
            graphics.DrawEllipse(new Pen(Color.Black), new Rectangle(point.X, point.Y, (int)A, (int)B));
            //}
        }

        public double B //вторая полуось эллипса
        {
            get { return b; }

            set { b = value; }
        }

        public override string GetClassName()
        {
            return "Ellipse";
        }

        public override double Perimeter()
        {
            return PI * Sqrt(2 * (Pow(A, 2) + Pow(B, 2)));
        }
    }
}
