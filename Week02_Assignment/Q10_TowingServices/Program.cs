using System;

namespace Q10_TowingServices
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int towingrate;
			int distance;
			int servicerate;
			//processing
			//Output
			int cost;
			//Algorithm
			Console.Write("Enter the towing rate (dollars/km): ");
			towingrate = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the distance (km): ");
			distance = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the flat service rate (dollars): ");
			servicerate = Convert.ToInt32(Console.ReadLine());
			cost = towingrate * distance + servicerate;

			Console.WriteLine(cost);
        }
    }
}
