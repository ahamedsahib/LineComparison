using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Copmarison Computation Program ");
            double LengthOfLine1, LengthOfLine2;
  
              double LengthCalculation()//method with return value as double
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

                //formula to calculate length of line 
                lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return lengthOfLine;
            }
            Console.WriteLine("Enter the coordinate of Line1");
            LengthOfLine1 = LengthCalculation();//calling LengthCalculation method to calculate length of line
            Console.WriteLine("Enter the coordinate of Line2");
            LengthOfLine2 = LengthCalculation();
            
            //comparing two lines using CompareTo()
            int result = LengthOfLine1.CompareTo(LengthOfLine2);
            
            if (result < 0)
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
            else if (result == 0)
            {
                Console.WriteLine("Line 1  equal to Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }

            Console.WriteLine("checking");
        }
    }
}