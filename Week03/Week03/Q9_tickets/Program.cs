using System;
/*
 * Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to
 * prompt the user for the amount of adult and child ticket that she needs.
 * The program will display a user friendly message of the number of tickets
 * brought as well as the total cost.
 * (Use the "C" format-specifier for currency).
 */
namespace Q9_tickets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int adult;
            int child;
            int totalticket;
            double totalcost;

            Console.Write("Enter the amount of adult ticket: ");
            adult = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of child ticket: ");
            child = Convert.ToInt32(Console.ReadLine());

            totalticket = adult + child;
            totalcost = Convert.ToDouble(3.75) * adult + Convert.ToDouble(2.25) * child;

            Console.WriteLine("The total amount of ticket purchased are {0}, and the total cost is {1:C}", totalticket, totalcost); 
        }
    }
}
