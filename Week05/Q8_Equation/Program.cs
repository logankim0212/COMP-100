using System;
/*
 * Write a program to calculate the roots of a quadratic equation.
 * The flowchart below illustrates a possible solution.
 */
namespace Q8_Equation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Enter the value of b: ");
			double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of c: ");
			double c = Convert.ToDouble(Console.ReadLine());
            double outcome1;
            double outcome2;

            if (a == 0)
            {
				Console.WriteLine("invalid input for a");
            }
            else
            {
				double p = (-b) / 2 * a;
				double d = b * b - 4 * a * c;
				if (d >= 0)
				{
					double q = Math.Sqrt(d) / (2 * a);
					outcome1 = p + q;
					outcome2 = p - q;
					Console.WriteLine("p + q = {0:f} and p - q = {1:f}"
									 , outcome1, outcome2);
				}
				else
				{
					double q = Math.Sqrt(-d) / (2 * a);
					outcome1 = p + q;
					outcome2 = p - q;
					Console.WriteLine("p + qi = {0:f} and p - qi = {1:f}"
									 , outcome1, outcome2);
				}
            }
		}
    }
}
