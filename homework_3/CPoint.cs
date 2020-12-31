using System;

namespace homework_3
{
    public class CPoint : CGraphicsObject
    {
        public CPoint(int x,int y)
        {
            X = x;

            Y = y;
        }

        public CPoint()
        {

        }

        ~CPoint()
        {
            Console.WriteLine("CPoint object destroyed");
        }
        
        public int X
        {
            get { return x; }
            set 
            {              
                x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }

        public override string Show()
        {
            return "Point coordinates: X = " + X + " Y = " + Y;
        }
    }
}