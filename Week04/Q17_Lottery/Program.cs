using System;
/*
 * Create a console-based lottery game application. Generate three random
 * numbers, each between 1 and 4. Allow the user to guess three numbers.
 * Compare each of the user’s guesses to the three random numbers and display
 * a message that includes the user’s guess, the randomly determined
 * three-digit number, and the amount of money the user has won as follows:
 *          Matching Numbers                 Award ($)
 *          Any one matching                    10
 *            Two matching                      100
 *     Three matching, not in order            1,000
 *     Three matching in exact order          10,000
 *             No matches                        0
 * Make certain that your application accommodates repeating digits.
 * For example, if a user guesses 1, 2, and 3, and the randomly generated
 * digits are 1, 1, and 1, do not give the user credit for three correct
 * guesses—just one.
 */
namespace Q17_Lottery
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Welcome to lottery game!");
			Console.WriteLine("There are three number that you need to guess.");
			Console.WriteLine("The numbers should be integers, between 1 and" +
                              " 4, can be repeated.");
			Console.WriteLine("If there is any one matching, you'll get $10.");
			Console.WriteLine("If there are two matchings, you'll get $100.");
			Console.WriteLine("If there are three matchings, not in order," +
                              " you'll get $1,000.");
			Console.WriteLine("If there are three matchings in exact order," +
                              " you'll get $10,000.");
			Console.WriteLine("However, if there is no matching, then you" +
                              " will not get anything.");
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the second number: ");
			int second = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the third number: ");
			int third = Convert.ToInt32(Console.ReadLine());

			Random lottery = new Random();
            int generator1 = lottery.Next(1, 5);
			int generator2 = lottery.Next(1, 5);
			int generator3 = lottery.Next(1, 5);

            if (generator1 == first)
            {
                if (generator2 == second)
                {
                    if (generator3 == third)
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $10,000. Your choice [{0}, {1}," +
                                          " {2}] are exactly matched with" +
                                          " [{3}, {4}, {5}].", first, second,
                                          third, generator1, generator2,
                                          generator3);
                    }
                    else
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
                    }
                }
                else if (generator2 == third)
                {
                    if (generator3 == second)
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $1,000. Your choice [{0}, {1}," +
                                          " {2}] are matched with [{3}, {4}," +
                                          " {5}]. But they weren't in order."
                                          , first, second, third, generator1,
                                          generator2, generator3);
                    }
                    else
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
                    }
                }
                else
                {
                    if (generator3 == second || generator3 == third)
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
                    }
                    else
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $10. We found one matching from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
                    }
                }
            }

            else if (generator1 == second)
            {
                if (generator2 == first)
                {
                    if (generator3 == third)
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $1,000. Your choice [{0}, {1}," +
                                          " {2}] are matched with [{3}, {4}," +
                                          " {5}]. But they weren't in order."
                                          , first, second, third, generator1,
                                          generator2, generator3);
                    }
                    else
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
                    }
                }
                else if (generator2 == third)
                {
                    if (generator3 == first)
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $1,000. Your choice [{0}, {1}," +
										  " {2}] are matched with [{3}, {4}," +
										  " {5}]. But they weren't in order."
										  , first, second, third, generator1,
										  generator2, generator3);
                    }
                    else
                    {
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
                    }
                }
                else
                {
					if (generator3 == first || generator3 == third)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $10. We found one matching from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
                }
            }

            else if (generator1 == third)
            {
				if (generator2 == first)
				{
					if (generator3 == second)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $1,000. Your choice [{0}, {1}," +
										  " {2}] are matched with [{3}, {4}," +
										  " {5}]. But they weren't in order."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
				}
				else if (generator2 == second)
				{
					if (generator3 == first)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $1,000. Your choice [{0}, {1}," +
										  " {2}] are matched with [{3}, {4}," +
										  " {5}]. But they weren't in order."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
				}
				else
				{
					if (generator3 == first || generator3 == second)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $10. We found one matching from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
				}
            }

            else
            {
				if (generator2 == first)
				{
					if (generator3 == second || generator3 == third)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $10. We found one matching from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
				}
				else if (generator2 == second)
				{
                    if (generator3 == first || generator3 == third)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $10. We found one matching from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
				}
				else if (generator2 == third)
				{
					if (generator3 == first || generator3 == second)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $100. We found two matchings from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $10. We found one matching from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
				}
				else
				{
                    if (generator3 == first || generator3 == second
                        || generator3 == third)
					{
						Console.WriteLine("Congratulations! You just earned" +
										  " $10. We found one matching from" +
										  " your choice [{0}, {1}, {2}]." +
										  " The numbers were [{3}, {4}, {5}]."
										  , first, second, third, generator1,
										  generator2, generator3);
					}
					else
					{
						Console.WriteLine("Sorry. There is no matching." +
                                          " So, there is no award." +
                                          " Your choice were [{0}, {1}, {2}]," +
										  " and the numbers were [{3}, {4}," +
                                          " {5}].", first, second, third,
                                          generator1, generator2, generator3);
					}
				}
            }
		}
    }
}
