using System;

namespace Question2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your annual salary: ");
            double annualsalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your monthly expenses: ");
            double monthlyexpenses = Convert.ToDouble(Console.ReadLine());

            double monthlysalary = annualsalary / 12;
            double extramoney = monthlysalary - monthlyexpenses;

            Console.WriteLine("Hi {0}, with a monthly salary of {1:c} and" +
                              " expenses of {2:c} you will have {3:c} of" +
                              " spending money", name, monthlysalary,
                              monthlyexpenses, extramoney); 
        }
    }
}
