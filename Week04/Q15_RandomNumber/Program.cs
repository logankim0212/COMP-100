using System;
/*
 * You can create a random number that is at least min but less than max using
 * the following statements:
 * Random ranNumberGenerator = new Random();
 * int randomNumber;
 * randomNumber = ranNumberGenerator.Next(min, max);
 * Write a console-based program that generates a random number between 1 and
 * 10. (In other words, min is 1 and max is 11.) Ask a user to guess the random
 * number, then display the random number and a message indicating whether the
 * user’s guess was too high, too low, or correct.
 */
namespace Q15_RandomNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.Write("Let's play a simple game between you and me." +
			  "I will choose a random integer between 1 and 10." +
			  " and you will guess the number that I choose." +
			  " Hmm, I chose one. Guess what number I am" +
			  " thinking of?: ");
			int guess = Convert.ToInt32(Console.ReadLine());

            Random ranNumberGenerator = new Random();
			int randomNumber = ranNumberGenerator.Next(1, 11);

            if (randomNumber > guess)
            {
                Console.WriteLine("The number that I chose is {0}." +
                                  " Unfortunately, your guess was too low."
                                  , randomNumber); 
            }
            else if (randomNumber < guess)
            {
				Console.WriteLine("The number that I chose is {0}." +
                                  " Unfortunately, your guess was too high."
								  , randomNumber); 
            }
            else
            {
				Console.WriteLine("Congratulations! You are correct!." +
                                  "The number that I chose is {0}. Good job!"
								  , randomNumber);
            }
        }
    }
}
