using System;

namespace ArrayDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] values = GenerateRandomArray(5);
            DisplayIntArray(values);
            Console.WriteLine("Average: {0:f}", AverageIntArray(values));
        }
        /*
         * 1.   Write a method with the following specifications:
         * name: GenerateRandomArray
         * arguments: an int representing the size of the array
         * return value: an int array
         * displays: nothing
         * tasks: creates a Random object, allocate enough storage for the
         * array, using a suitable loop, assign a random number from 10 to 20
         * to each spot in the array
         * Call this method from your main.
         */
        static int[] GenerateRandomArray(int size)
        {
            Random rnd = new Random();
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = rnd.Next(10, 20);
            }
            return result;
        }
        /* 2.   Write a method with the following specifications:
         * name: DisplayIntArray
         * arguments: an int array
         * return value: none
         * tasks: displays all the items in the array on a single line separated by a space
         * In your main, figure out how to display the output of the previous method
         */
        static void DisplayIntArray(int[] toPrint)
        {
            foreach (int item in toPrint)
            {
                Console.Write(item + " "); 
            }
        }
        /* 3.    Write a method with the following specifications:
         * name: AverageIntArray
         * arguments: an int array
         * return value: double representing the arithmetic average of all the elements 
         * displays: nothing 
         * tasks: sums all the items and then divide by the size and return this value
         * In your main write the code that will exercise this method.
         */
        static double AverageIntArray(int[] toProcess)
        {
            int sum = 0;
            foreach (int x in toProcess)
            {
                sum += x;
            }
            return (double)sum / toProcess.Length;
        }
        /* 4.   Write a method with the following specifications:
         * name: AssignBonus
         * arguments: int representing the bonus and an int array representing the marks 
         * return value: nothing
         * displays: nothing 
         * tasks: adds the bonus to each element of the array.
         * In your main you will call this method and then display the items afterwards.
         * You should see each item increased by the amount specified by your bonus.
         */

    }
}
