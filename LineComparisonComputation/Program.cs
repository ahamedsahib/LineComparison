using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Copmarison Computation Program ");
            double LengthOfLine1, LengthOfLine2;
  
              double LengthCalculation()
            {
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
                return lengthOfLine;
            }
            Console.WriteLine("Enter the coordinate of Line1");
            LengthOfLine1 = LengthCalculation();
            Console.WriteLine("Enter the coordinate of Line2");
            LengthOfLine2 = LengthCalculation();

            bool result = LengthOfLine1.Equals(LengthOfLine2);
            if(result == true)
            {
                Console.WriteLine("both are not equal");
            }
            else
            {
                Console.WriteLine("both are not equal");
            }
            
            /*Console.WriteLine("Length of the Line1 :" + LengthOfLine1);
            Console.WriteLine("Length of the Line1 :" + LengthOfLine2);
            */
        }
    }
}