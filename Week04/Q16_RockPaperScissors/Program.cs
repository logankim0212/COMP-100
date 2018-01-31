using System;
/*
 * In the game Rock Paper Scissors, two players simultaneously choose one of
 * three options: rock, paper, or scissors. If both players choose the same
 * option, then the result is a tie. However, if they choose differently,
 * the winner is determined as follows:
 * Rock beats scissors, because a rock can break a pair of scissors.
 * Scissors beats paper, because scissors can cut paper.
 * Paper beats rock, because a piece of paper can cover a rock.
 * Create a console-based game in which the computer randomly chooses rock,
 * paper, or scissors. Let the user enter a character, ‘r’, ‘p’, or ‘s’, each
 * representing one of the three choices. Then, determine the winner.
 */
namespace Q16_RockPaperScissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's play rock-paper-scissors!");
            Console.WriteLine("If you want to choose rock, type r.");
			Console.WriteLine("If you want to choose paper, type p.");
			Console.WriteLine("If you want to choose scissors, type s.");
            Console.Write("So, what's your choice?: ");
            string userchoice = Console.ReadLine(); 

			Random rockpaperscissors = new Random();
            int computerchoice = rockpaperscissors.Next(3);

            if (computerchoice == 0)
            {
                if (userchoice == "r" || userchoice == "R")
                {
                    Console.WriteLine("It's a tie! I chose rock as well.");
                }
                else if (userchoice == "p" || userchoice == "P")
                {
                    Console.WriteLine("Congratulations, you won! I chose" +
                                      " rock. Paper beats rock.");
                }
                else if (userchoice == "s" || userchoice == "S")
                {
                    Console.WriteLine("Sorry, you lost. I chose rock." +
                                      " Rock beats scissors.");
                }
				else
				{
					Console.WriteLine("Opps, I found an error. I guess you" +
									  " didn't type r, s, or p.");
				}
            }
            else if (computerchoice == 1)
            {
                if (userchoice == "r" || userchoice == "R")
                {
					Console.WriteLine("Sorry, you lost. I chose paper." +
									  " Paper beats rock.");
                }
                else if (userchoice == "p" || userchoice == "P")
                {
					Console.WriteLine("It's a tie! I chose paper as well.");
				}
                else if (userchoice == "s" || userchoice == "S")
                {
					Console.WriteLine("Congratulations, you won! I chose" +
									  " paper. Scissors beat paper.");

                }
				else
				{
					Console.WriteLine("Opps, I found an error. I guess you" +
									  " didn't type r, s, or p.");
				}
            }
            else if (computerchoice == 2)
            {
                if (userchoice == "r" || userchoice == "R")
                {
                    Console.WriteLine("Congratulations, you won! I chose" +
									  " scissors. Rock beats scissors.");                }
                else if (userchoice == "p" || userchoice == "P")
                {
					Console.WriteLine("Sorry, you lost. I chose scissors." +
									  " Scissors beat paper.");
                }
                else if (userchoice == "s" || userchoice == "S")
                {
					Console.WriteLine("It's a tie! I chose scissors as well.");
				}
				else
				{
					Console.WriteLine("Opps, I found an error. I guess you" +
									  " didn't type r, s, or p.");
				}
            }
        }
    }
}
