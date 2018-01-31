using System;

namespace Q7_Plumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int lengthrate;
			int joinrate;
			int length;
			int numberofjoins;
			//processing
			//Output
			int cost;
			//Algorithm
			Console.Write("Enter the length rate (dollars/m): ");
			lengthrate = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the join rate (dollars/ea): ");
			joinrate = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the length (meter): ");
			length = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the number of joins: ");
			numberofjoins = Convert.ToInt32(Console.ReadLine());
			cost = (length * lengthrate) + (numberofjoins * joinrate);

			Console.WriteLine(cost);
        }
    }
}
