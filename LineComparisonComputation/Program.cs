using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Copmarison Computation Program ");
            int x1, x2, y1, y2;
            double lengthOfLine;

            Console.WriteLine("Enter X-coordinate X1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y-coordinate Y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X-coordinate X2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y-coordinate Y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

  
            lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Length of the Line :{lengthOfLine}");

        }
    }
}
