using System.Drawing;
using System.Windows.Forms;

namespace homework_4
{
    public abstract class CGraphicsObject
    {
        protected Point point;

        public abstract double Perimeter();

        public virtual string GetClassName()
        {
            return "CGraphicsObject";
        }

        public virtual void Show(Label label)
        {

        }

        public virtual void Draw(Graphics graphics)
        {

        }
        public static double operator +(CGraphicsObject graphicsObject1, CGraphicsObject graphicsObject2)
        {
            return graphicsObject1.Perimeter() + graphicsObject2.Perimeter();
        }

    }
}