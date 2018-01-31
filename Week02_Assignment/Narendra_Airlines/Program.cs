using System;

namespace Narendra_Airlines
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //input
            int FuelEfficiency;
            int LengthTravel;
            int UnitPrice;

            //output
            int Cost;

            //processing

            //Algorithm
            Console.Write("Enter fuel efficiency(Km/L): ");
            FuelEfficiency = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the length of travel(Km): ");
			LengthTravel = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the unit price of fuel(L): ");

			UnitPrice = Convert.ToInt32(Console.ReadLine());

            Cost = LengthTravel * UnitPrice * FuelEfficiency;

            Console.WriteLine(Cost);

		}
    }
}
