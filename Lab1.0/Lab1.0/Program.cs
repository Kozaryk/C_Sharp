using System;
using System.Collections.Generic;

namespace Lab1

{
internal class Program
{
    public static void Main(string[] args)
    {
            double x = 2, y = 12, y1, y2, y3, y4, y5, a=8, b=24;

            y1 = (Math.Pow(a, 4) + (Math.Pow(b, 5))) / (Math.Sqrt(Math.Pow(a, 3) + Math.Pow(a, 6))) -
                 (Math.Pow((Math.Abs(a - b)) + (Math.Abs(b - a)), 2)) / ((a * b) - Math.Pow (a*b, 2));
       
                System.Console.WriteLine(y1);

            y2 = (Math.Sqrt(y1) + Math.Pow(y1, 3) - Math.Cos(5 * x + 2) / Math.Sqrt(Math.Pow(y1, 2))) *
             Math.Log10(5 - Math.Pow(x, 2));

                System.Console.WriteLine(y2);

            y3 = (Math.Log10(5 + Math.Pow(x, 3)) - (Math.Log(x * x, 5) + Math.Log(6 * y, 5)) * (Math.Pow(y1, 2) / y2));
            
                System.Console.WriteLine(y3);

            y4 = (Math.Pow(Math.Abs(y3 - y2 - y1), 2) / Math.Pow((y3 + y2 + y1), 2) *
              (Math.Sqrt(Math.Abs(y3 - y2 - y1)) / (2 * Math.Pow(x, 3))));
        
                System.Console.WriteLine(y4);

        y5 = (((Math.Abs(a * b) + 1) / Math.Abs(y1 * y2)) -
              (1.3 * Math.Pow(x, 2)) / (Math.Pow(y1, 3) - Math.Pow(y2, 2)));
        
        System.Console.WriteLine(y5);
    }
}
}