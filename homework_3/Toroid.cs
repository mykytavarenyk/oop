using System;
using System.Text;

namespace homework_3
{
    public class Toroid : CPoint
    {
        public double BigRadius
        {
            get { return bigRadius; }
            set
            {
                bigRadius = value;
            }
        }

        public double SmallRadius
        {
            get { return smallRadius; }
           
            set
            {
                smallRadius = value;
            }
        }

        public double Volume
        {
            get { return 2*Math.Pow(Math.PI,2)*BigRadius*Math.Pow(SmallRadius,2); }
        }

        public double Area
        {
            get { return 4*Math.PI*BigRadius*SmallRadius; }
        }

        public Toroid(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Toroid()
        {

        }

        public Toroid(double bigRadius, double smallRadius) 
        {
            BigRadius = bigRadius;

            SmallRadius = smallRadius;
        }

        public override string Show()
        {
            Type[] types = new Type[4];

            Type currentType = new Toroid().GetType();

            int i = 0;

            while (currentType != null)
            {
                types[i] = currentType;

                currentType = currentType.BaseType;

                i++;
            }

            StringBuilder stringBuilder = new StringBuilder();

            for(int j = 0; j < types.Length; j++)
            {
                if(j == types.Length - 1)
                {
                    stringBuilder.Append(types[j]);

                    break;
                }

                stringBuilder.Append(types[j] + ", ");
            }

            return "Volume = " + Volume + ", Area = " + Area + " X = " + X + ", Y = " + Y + ", base types " + stringBuilder.ToString();           
        }


        ~Toroid()
        {
            Console.WriteLine("Tor object deleted");
        }
    }
}