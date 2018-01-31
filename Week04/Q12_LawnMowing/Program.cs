using System;
/*
 * Write a console-based program for a lawn-mowing service. The lawn-mowing
 * season lasts 20 weeks. The weekly fee for mowing a lot less thawn 400 square
 * feet is $25. The fee for a lot that is 400 square feet or more, but less
 * than 600 square feet, is $35 per week. The fee for a lot that is 600 square
 * feet or over is $50 per week. Prompt the user for the length and width of a
 * lawn, and then display the weekly mowing fee, as well as the total fee for
 * the 20-week season. 
 */
namespace Q12_LawnMowing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the length of a lawn (ft): ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of a lawn (ft): ");
            int width = Convert.ToInt32(Console.ReadLine());
            int area = length * width;
            if (area < 400)
            {
                int weeklyfee = area * 25;
                int seasonfee = weeklyfee * 20;
                Console.WriteLine("The weekly mowing fee is {0:c}, and the" +
                                  " total fee for the 20-week season is" +
                                  " {1:c}.", weeklyfee, seasonfee); 
            }
			else if (area > 400 && area < 600)
			{
                int weeklyfee = area * 35;
				int seasonfee = weeklyfee * 20;
				Console.WriteLine("The weekly mowing fee is {0:c}, and the" +
								  " total fee for the 20-week season is" +
								  " {1:c}.", weeklyfee, seasonfee);
			}
			else if (area > 600)
			{
                int weeklyfee = area * 50;
				int seasonfee = weeklyfee * 20;
				Console.WriteLine("The weekly mowing fee is {0:c}, and the" +
								  " total fee for the 20-week season is" +
								  " {1:c}.", weeklyfee, seasonfee);
			}
        }
    }
}
