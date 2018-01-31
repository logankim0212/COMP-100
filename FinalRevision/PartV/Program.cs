using System;

namespace PartV
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            showMenu();
        }
        static void displayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("|  1)  Display Int Array                    |");
            Console.WriteLine("|  2)  Generate Random Array                |");
            Console.WriteLine("|  3)  Count Evens and Odds                 |");
            Console.WriteLine("|  4)  Calculate Digit Frequencies          |");
            Console.WriteLine("|  5)  Calculate Last Digit Frequencies     |");
            Console.WriteLine("|  6)  Calculate Bucket Number Frequencies  |");
            Console.WriteLine("|  7)  LetterFrequency                      |");
            Console.WriteLine("|  8)  Binary String                        |");
            Console.WriteLine("|  9)  Mortgage Calculation                 |");
            Console.WriteLine("|  10) Count Evens and Odds                 |");
            Console.WriteLine("|  11) Calculate Digit Frequencies          |");
            Console.WriteLine("|  12) Calculate Last Digit Frequencies     |");
            Console.WriteLine("|  13) Calculate Bucket Number Frequencies  |");
            Console.WriteLine("|  14) LetterFrequency                      |");
            Console.WriteLine("|  0)  End program                          |");
            Console.WriteLine("+-------------------------------------------+");
            Console.Write("       Enter your choice -> ");
        }
        static void showMenu()
        {
            string choice;
            do
            {
                displayMenu();
                choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "0":
                        break;
                    case "1":
                        int[] a1 = {5,12,8,5,7,3,5,6,9,10,16,8,11,34,9,50,12,14,45};
                        DisplayIntArray(a1);
                        break;
                    case "2":
                        int[] a2;
                        a2 = GenerateRandomIntArray(15, 10);
                        DisplayIntArray(a2);
                        Console.WriteLine(); 
                        a2 = GenerateRandomIntArray(25, 10);
                        DisplayIntArray(a2);
                        Console.WriteLine(); 
                        a2 = GenerateRandomIntArray(30, 100);
                        DisplayIntArray(a2);
                        break;
                    case "3":
                        int[] a3, b3;
                        a3 = GenerateRandomIntArray(20, 100);
                        DisplayIntArray(a3);
                        Console.WriteLine(); 
                        b3 = CountEvenOdd(a3);
                        DisplayIntArray(b3); 
                        break;
                    case "4":
                        int[] a4, b4;
                        a4 = GenerateRandomIntArray(20, 10);
                        DisplayIntArray(a4);
                        Console.WriteLine();
                        b4 = CalculateDigitFrequencies(a4);
                        DisplayIntArray(b4);
                        break;
                    case "5":
                        int[] a5, b5;
                        a5 = GenerateRandomIntArray(20, 100);
                        DisplayIntArray(a5);
                        Console.WriteLine();
                        b5 = CalculateLastDigitFrequencies(a5);
                        DisplayIntArray(b5);
                        break;
                    case "6":
                        int[] a6, b6;
                        a6 = GenerateRandomIntArray(20, 100);
                        DisplayIntArray(a6);
                        Console.WriteLine();
                        b6 = CalculateNumberFrequencies(a6);
                        DisplayIntArray(b6);
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    case "11":
                        break;
                    case "12":
                        break;
                    case "13":
                        break;
                    case "14":
                        break;
                }
            } while (choice != "0");
        }
        /*
         * 1.   Write a method with header static void DisplayIntArray(int[]
         * numbers). The first argument is an array of ints. There is no return
         * value. This method displays all the elements of the argument on a
         * single line. Each item will occupy three columns.
         * Call this method from main with a suitable argument.
         */
        static void DisplayIntArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0,3}", numbers[i]); 
            }
        }
        /*
         * 2.   Write a method with header static int[] GenerateRandomIntArray
         * (int numberOfItems, int largestValue). The first argument is an int
         * indicating the number of elements that will be present in the return
         * array. The second argument is an int representing the largest item 
         * in the array. The returned value is an array of integers. This
         * method does the following:
         * a.  Declare and initialized a variable of type Random (Random 
         * generator = new Random();)
         * b.  Declare an array of type int (you may call it result)
         * c.  Allocate storage for the correct number of items
         * d.  Using your favorite looping statement, assign a random integer to
         * each element of the array (result[i] = generator.Next(largestValue);)
         */
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            Random generator = new Random();
            int[] result = new int[numberOfItems];
            int counter = 0;
            do
            {
                result[counter++] = generator.Next(largestValue);
            } while (counter < numberOfItems);
            return result;
        }
        /*
         * 3.   Write a method with header static int[] CountEvenOdd(int[]
         * array). The argument is an int array. The returned value is an 
         * array of 2 integers. The elements of the return array will be a 
         * count of the odd and even items in the argument. The first element
         * of the returned array represents the number of odds in the argument
         * and the second element indicates the number of evens in the argument.
         * The method will create an int array of 2 elements (call this the
         * result). Each item of the argument is examined and the appropriate
         * element of the result array is incremented. 
         * In your main method, create an int array using the 
         * GenerateRandomIntArray() method and then print out the elements
         * using the DisplayIntArray() method. Call the above method and 
         * display the return value. Do a count to verify that your method
         * is working correctly.
         */
        static int[] CountEvenOdd(int[] array)
        {
            int[] result = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                result[array[i] % 2]++; 
            }
            return result;
        }
        /*
         * 4.   Write a method with header static int[] CalculateDigitFrequencies
         * (int[] array). The argument is an int array with values ranging from
         * 0 to 9. The returned value is an array of 10 integers. The elements
         * of the return array will be a count of the frequencies of the items
         * in the argument. The first element of the returned array represents
         * the number of 0’s in the argument, the second element indicates the
         * number of 1’s in the argument and the third element will indicate 
         * the number of 2’s in the argument.
         * The method will create an int array of 10 elements (call this the
         * result). Each item of the argument is examined and the appropriate 
         * element of the result array is incremented. 
         * In your main method, create an int array using the 
         * GenerateRandomIntArray() method remember to use 10 as the second
         * argument to the method and then print out the elements using the 
         * DisplayIntArray() method. Call the above method and display the 
         * return value. Do a count to verify that your method is working 
         * correctly.
         */
        static int[] CalculateDigitFrequencies(int[] array)
        {
            int frequency;
            int[] result = new int[10];
            for (int i = 0; i < 10; i++)
            {
                frequency = 0;
                foreach(int item in array)
                {
                    if (item == i)
                    {
                        frequency++;
                    }
                }
                result[i] = frequency;
            }
            return result;
        }
        /*
         * 5.   Write a method with header static int[] CalculateLastDigitFrequencies
         * (int[] array). The argument is an int array. The returned value is an 
         * array of 10 integers. The elements of the return array will be a count
         * of the frequencies of the items in the argument. The first element of
         * the returned array represents the number with last digit of 0’s in 
         * the argument, the second element indicates the number with last digit 
         * of 1’s in the argument and the third element will indicate the number
         * with last digit of 2’s in the argument.
         * The method will create an int array of 10 elements (call this the
         * result). Each item of the argument is examined and the appropriate 
         * element of the result array is incremented. 
         * In your main method, create an int array using the 
         * GenerateRandomIntArray() method and then print out the elements 
         * using the DisplayIntArray() method. Call the above method and 
         * display the return value. Do a count to verify that your method 
         * is working correctly.
         */
        static int[] CalculateLastDigitFrequencies(int[] array)
        {
            int[] result = new int[10];
            foreach (int item in array)
            {
                result[item % 10]++;
            }
            return result;
        }
        /*
         * 6.   Write a method with header static int[] CalculateNumberFrequencies
         * (int[] array). The argument is an int array with values ranging from 
         * 0 to 99. The returned value is an array of 10 integers. The first 
         * element will indicate the number or unit values in the argument 
         * (i.e. values 0-9), the second element will indicate the number of 10 
         * values (i.e. values 10-19), the third element will indicate the 
         * number of 20 values (i.e. values 20-29) etc.
         * The method will create an int array of 10 elements (call this the
         * result). Each item of the argument is examined and the appropriate
         * element of the result array is incremented. 
         * In your main method, create an int array using the 
         * GenerateRandomIntArray() method and then print out the elements 
         * using the DisplayIntArray() method. Call the above method and
         * display the return value. Do a count to verify that your method 
         * is working correctly.
         */
        static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] result = new int[10];
            foreach (int item in array)
            {
                result[item / 10]++;
            }
            return result;
        }
        /*
         * 7.   Write a method that takes a string and return a distribution of
         * the letter in the string. A distribution can be an array of the 
         * letter frequencies. To simplify code, you may assume that all the
         * letters will be lowercased (or uppercased) and there are no periods
         * or spaces. Call the above method and display the return value. Do a
         * count to verify that your method is working correctly.
         */


        /*
         * 8.   Write a method that returns a binary string representation of
         * its argument. Call this method from your main and display the
         * returned values. If you call the method three times with the
         * integers 7, 128 and 15 respectively the method will return the
         * binary strings 111, 10000000 and 1111 respectively.
         */


        /*
         * 9.   Write a method that will return the year-end balance for a
         * mortgage, given the beginning balance, the yearly interest rate,
         * and the bi-weekly payments. You can assume that there are 26 
         * payments in the year and the mortgage is re-calculated after each
         * payment. For each period, you will need to calculate the interest 
         * (you will need to calculate the daily interest and times it by the
         * number of days in each period), then add this to the starting 
         * balance and then subtract the payment. If the starting principal 
         * is $300,000, the interest rate is 2.5% and the bi-weekly payment 
         * is $1,000, what will be the year-end balance? How much would you 
         * save if you increased the monthly payment by $100?
         */


        /*
         * 10.  Write a method that will display the nth term of a Fibonacci
         * sequence. The nth term is defined as the sum of the two previous
         * terms. The first few terms of the Fibonacci series are 1, 1, 2, 3,
         * 5, 8, 13, 21, etc.
         */


        /*
         * 11.  Write a method that will return the factorial of its argument
         * number. [n! = n(n-1)(n-2)(n-3)… (1)] 
         */


        /*
         * 12.   Write a method that computes the value of PI given by the
         * expression π/4=1-1/3+1/5-1/7+1/9-1/11⋯. How many terms are needed
         * to match Math.PI?
         */


        /*
         * 13.  Write a method that takes two integers and returns the greatest
         * common divisor (gcd).
         */


        /*
         * 14.  Write a method similar to question 3, that counts the
         * distribution of two-letters combinations i.e. digrams
         */


    }
}
