using System.Windows.Forms;
using static System.Math;
using System.Drawing;

namespace homework_4
{
    public class Circle : CGraphicsObject
    {
        private double radius;

        public Circle(double radius, int x, int y)
        {
            this.radius = radius;
            point = new Point(x, y);
        }

        ~Circle()
        {

        }

        public double Radius // радиус окружности
        {
            get { return radius; }

            set { radius = value; }
        }

        public override string GetClassName()
        {
            return "Circle";
        }

        public override double Perimeter()
        {
            return 2 * PI * Radius;
        }

        public override void Show(Label label)
        {
            label.Text = GetClassName() + ": \nRadius=" + Radius + "\nPerimeter=" + Perimeter() + "\n";
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color.Black), new Rectangle(point.X, point.Y, (int)Radius, (int)Radius));
        }
    }
}