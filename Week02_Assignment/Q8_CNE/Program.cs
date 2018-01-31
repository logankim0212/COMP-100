using System;

namespace Q8_CNE
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int ticketbought;
			int polarexpress;
			int ferriswheel;
			//processing
			//Output
			int leftover;
			//Algorithm
			Console.Write("Enter the amount of ticket bought: ");
			ticketbought = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the number of times that Polar Express was taken: ");
		
			polarexpress = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the number of times that Ferris Wheel was taken: ");
		
			ferriswheel = Convert.ToInt32(Console.ReadLine());
			leftover = ticketbought - polarexpress * 5 - ferriswheel * 3;

			Console.WriteLine(leftover);
        }
    }
}
