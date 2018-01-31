using System;

namespace ArrayAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            /* 4. In your main method use the method in question 1 to display the
             * letters array, then use the Array.Reverse() method to reverse the
             * letters array and then again call the appropriate method to print it
             */
            //printCharArray(letters);
            //Console.WriteLine();
            //Array.Reverse(letters);
            //printCharArray(letters);
            //Console.WriteLine();
            /* 5.   In your main method use the method in question 3 to display
             * the poem array, then use the Array.Sort() method to sort the poem
             * array and then again call the appropriate method to print it
             */
            //printStringArray(poem);
            //Console.WriteLine();
            //Array.Sort(poem);
            //printStringArray(poem);
            //Console.WriteLine();
            /* 6.   In your main method use the method in question 2 to display
             * the numbers array, then use the Array.Binarysearch() method to
             * try to find the position of 3 in the numbers array. What is your
             * answer?
             * Now repeat the same steps after you have sorted the array and
             * printed the sorted array
             */
            //printIntArray(numbers);
            //Console.WriteLine();
            //Array.Sort(numbers);
            //int position = Array.BinarySearch(numbers, 3);
            //Console.WriteLine(position);
            /* Question 7 */
            //int[] value = promptNumber(5);
            //printIntArray(value);
            //Console.WriteLine();
            /* Question 8 */
            //int[] value = GenerateRandomArray(5);
            //printIntArray(value);
        }
        /* 1.   Write a method that takes an argument (a char array) and print
         * each item on a single line separated by a space. From your main,
         * call this method with letters as argument
         */
        static void printCharArray(char[] letter)
        {
            int counter = 0;
            while (counter < letter.Length)
            {
                Console.Write(letter[counter] + " ");
                counter++;
            }
        }
        /* 2.   Write a method that takes an argument (an int array) and print
         * each item on a single line separated by a space. From your main,
         * call this method with numbers as argument
         */
        static void printIntArray(int[] number)
        {
            int counter = 0;
            while (counter < number.Length)
            {
                Console.Write(number[counter] + " ");
                counter++;
            }
        }
        /* 3.   Write a method that takes an argument (a string array) and print
         * each item on a single line separated by a space. From your main, call
         * this method with poem as argument
         */
        static void printStringArray(string[] poem1)
        {
            int counter = 0;
            while (counter < poem1.Length)
            {
                Console.Write(poem1[counter] + " ");
                counter++;
            }
        }
        /* 7.   Write a method that creates and return an array of ints.
         * The method takes a single argument that represents the number of
         * items in the resulting array and does the following:
         * Declare an array of the required type
         * Allocate memory for the intended number of items
         * Using any looping structure, prompt the user for a number and then
         * assign to each element. 
         * In your main method call this method and display the returned value.
         */
        static int[] promptNumber(int item)
        {
            int[] result = new int[item];
            for (int i = 0; i < item; i++)
            {
                Console.Write("Enter a number {0}: ", i+1);
                int number = Convert.ToInt32(Console.ReadLine());
                result[i] = number;
            }
            return result;
        }
        /* 8.   Write another method that creates and return an array of ints.
         * The method takes a single argument that represents the number of
         * items in the resulting array and does the following:
         * Declare an array of the required type
         * Allocate memory for the intended number of items
         * Using any looping structure, assign to each element a random integer
         * in the range 100 to 200. 
         * In your main method call this method and display the returned value.
         * Radom rand = new Random();
         * rand.Next(100, 200);
         */
        static int[] GenerateRandomArray(int item)
        {
            Random rand = new Random();
            int[] result = new int[item];
            for (int i = 0; i < item; i++)
            {
                result[i] = rand.Next(100, 200);
            }
            return result;
        }
    }
}
