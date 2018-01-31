using System;
/*
 * The average cost of a college textbook is $125. There is a premium of 20%
 * on hardcover text and a discount of 5% on sales of more than 4 textbooks.
 * Write a program to prompt the user for the appropriate inputs and compute
 * and display the before-tax cost of the textbooks.
 * Sample calculation: 
 * price of 10 hardcover text = 10 * 125 + premium –discount
 * price = 1250 + 20% of 1250 – 5% of 1250
 * price = $1437.50
 * price of 8 softcover text = 8 * 125 –discount
 * price = 1000  – 5% of 1000
 * price = $950
 * price of 2 softcover text = 2 * 125
 * price = $250
 */
namespace Q7_Textbook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the nubmer of the softcover textbook" +
                              " that you bought: ");
            int softcover = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of the hardcover textbook" +
                          " that you bought: ");
            int hardcover = Convert.ToInt32(Console.ReadLine());
            int totalbook = softcover + hardcover;
			double pricesoftcover = 125 * softcover;
			double pricehardcover = 125 * hardcover * 1.2;
            if (totalbook <= 4)
            {
                double totalcost = pricesoftcover + pricehardcover;
                Console.WriteLine("The total before-tax cost of the" +
                                  " textbooks that you bought is {0:c}."
                                 , totalcost);
            }
            else
            {
                double totalcost = pricesoftcover * 0.95 + pricehardcover
                                                     - 125 * hardcover * 0.05;
                Console.WriteLine("The total before-tax cost of the" +
                                  " textbooks that you bought is {0:c}"
                                  , totalcost); 
            }
        }
    }
}
