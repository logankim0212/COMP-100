using System;
/*
 * Write an application that asks a user to enter an IQ score. If the score is
 * a number less than 0 or greater than 200, issue an error message; otherwise,
 * issue an “above average”, “average”, or “below average” message for scores
 * over, at, or under 100, respectively.
*/
namespace Q5_IQScore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the IQ score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score < 0 || score > 200)
            {
                Console.WriteLine("Error: {0} cannot be an IQ score.", score);
            }
            if (score > 100)
            {
                Console.WriteLine("The IQ {0} is above average. (The average" +
                                  " IQ is 100)", score);
			}
			if (score == 100)
			{
                Console.WriteLine("The IQ {0} is the average. (The average" +
                                  " IQ is 100)", score);
			}
			if (score < 100)
			{
                Console.WriteLine("The IQ {0} is below average. (The average" +
                                  " IQ is 100)", score);
			}
        }
    }
}
