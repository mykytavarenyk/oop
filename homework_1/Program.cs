using System;

namespace homework_1
{
    class Program
    {     
       public static void Main(string[] args)
       {
          Console.Write("Enter x:");

          double x = Convert.ToDouble(Console.ReadLine());

          double result = Math.Tan(x - Math.PI);

          Console.WriteLine(result);
       }
    }
}
