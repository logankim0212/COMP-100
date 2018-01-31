using System;

namespace Q1_WireInstallation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int AverageLength;
            int NumberofHouses;
			//Processing
			//Output
            int TotalLength;
			//Algorithm
			Console.Write("Enter the average length of wire required for a home: ");
			AverageLength = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the number of houses to wire: ");
			NumberofHouses = Convert.ToInt32(Console.ReadLine());
			TotalLength = AverageLength * NumberofHouses;

			Console.WriteLine(TotalLength);
        }
    }
}
