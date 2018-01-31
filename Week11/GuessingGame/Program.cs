using System;
/*The entire game will be coded in Main()
 * 1.  You will create a Random object in global scope. Then you will generate
 *     a random number less than 100, this will be your target.
 * 2.  In a loop you will prompt the user for a number guess. You will compare
 *     it with the target. If they match, then the user wins the game, otherwise
 *     display a suitable message.
 * 3.  If the user is not able to guess the target within a certain number of
 *     guesses, then end the game by displaying an encouraging message and the
 *     number of guesses and the target value
 * Using a binary search algorithm you will be able to guess any number up to
 * 128 within 7 attempts.
 */
namespace GuessingGame
{
    class MainClass
    {
        static Random generator = new Random();
        const int MAX_GUESS = 100;
        const int MAX_TRIES = 6;

        public static void Main(string[] args)
        {
            int target = generator.Next(MAX_GUESS);
            int counter = 0;
            while (counter < MAX_TRIES)
            {
                Console.Write("Enter a number less than {0} -> ", MAX_GUESS);
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == target)
                {
                    Console.WriteLine("WIN: you guessed {0} in {1} tries", target, counter);
                    return;
                }
                if (guess < target)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Too high");
                }
                counter++;
            }
            Console.WriteLine("LOST: You could not guess {0} in {1} tries", target, counter);
        }
    }
}
