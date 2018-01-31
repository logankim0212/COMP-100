using System;

namespace Q2_FertilizingField
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int rate;
			int unitprice;
			int size;
			//Processing
			//Output
			int cost;
			//Algorithm
			Console.Write("Enter the rate of fertilizer (kg/ha): ");
			rate = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the unit price of fertilizer (dollars/kg): ");
			unitprice = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the size of land (hectares): ");
			size = Convert.ToInt32(Console.ReadLine());
			cost = rate * unitprice * size;
			Console.WriteLine(cost);
		}
    }
}
