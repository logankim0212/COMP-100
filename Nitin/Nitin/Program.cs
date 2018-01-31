using System;

namespace Nitin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ShowMenu();
        }
        static void displayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine("| 1. Calculate Tax                   |");
            Console.WriteLine("| 2. Double It                       |");
            Console.WriteLine("| 3. Int Array                       |");
            Console.WriteLine("| 4. Count Vowels Modularized        |");
            Console.WriteLine("| 5. Calculate Discounted Price      |");
            Console.WriteLine("| 0. End program                     |");
            Console.WriteLine("+------------------------------------+");
            Console.Write("     Enter your choice -> ");
        }
        static void ShowMenu()
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
                        double cost, rate, tax;
                        cost = 10000;
                        rate = 0.20;
                        tax = CalculateTax(cost);
                        Console.WriteLine(tax);
                        tax = CalculateTax(cost, rate);
                        Console.WriteLine(tax);
                        break;
                    case "2":
                        int val;
                        val = 5;
                        Console.Write("Before method call: {0}, ", val);
                        DoubleIt(ref val);
                        Console.WriteLine("after method call: {0}", val);
                        val = 7;
                        Console.Write("Before method call: {0}, ", val);
                        DoubleIt(ref val);
                        Console.WriteLine("after method call: {0}", val);
                        break;
                    case "3":
                        int[] array = { 100, 200, 300, 400 };
                        int[] result = printIntArray(array);
                        DisplayIntArray(result);
                        break;
                    case "4":
                        string poem = "mary had a little lamb its fleece was white as snow";
                        int[] value = CountVowelsModularized(poem);
                        DisplayIntArray(value);
                        break;
                    case "5":
                        int quentity;
                        double discount, result5;
                        quentity = 2;
                        CalculateDiscount(quentity, out discount, out result5);
                        Console.WriteLine("Price: $6.00, Quentity: {0}, Discount: {1}%, Price" +
                                          " after discount: {2:F}"
                                          , quentity, discount, result5);
                        quentity = 7;
                        CalculateDiscount(quentity, out discount, out result5);
                        Console.WriteLine("Price: $6.00, Quentity: {0}, Discount: {1}%, Price" +
                                          " after discount: {2:F}"
                                          , quentity, discount, result5); 
                        quentity = 13;
                        CalculateDiscount(quentity, out discount, out result5);
                        Console.WriteLine("Price: $6.00, Quentity: {0}, Discount: {1}%, Price" +
                                          " after discount: {2:F}"
                                          , quentity, discount, result5);
                        quentity = 17;
                        CalculateDiscount(quentity, out discount, out result5);
                        Console.WriteLine("Price: $6.00, Quentity: {0}, Discount: {1}%, Price" +
                                          " after discount: {2:F}"
                                          , quentity, discount, result5);
                        break;
                }
            } while (choice != "0");
        }
        /*
         * 1.   Write a method that returns a double and takes two double 
         * arguments, one mandatory and one optional. The first argument 
         * represents the cost of an article and the second represent the tax 
         * rate (the default tax rate is 0.14). The will calculate the tax and 
         * return this value.
         * From your main, call this method twice, once with one argument and
         * then with two arguments and displaying the both results in simple
         * format
         */
        static double CalculateTax(double cost, double rate = 0.14)
        {
            double tax;
            tax = cost * rate;
            return tax;
        }
        /*
         * 2.   Write a method call DoubleIt(ref int x) that takes a single
         * argument and does not return a value. The method will double the
         * value of its argument
         */
        static void DoubleIt(ref int x)
        {
            x = x * 2;
        }
        /*
         * 3.   Write a C# program that returns array element (100,200,300,400).
         * Use Ref to return the array. Declare 4 elements in the main method. 
         * Change the first element to new value 900  inside the main method .  
         * The program should return the following output:
         * 900 
         * 200
         * 300
         * 400 
         */
        static void DisplayIntArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static int[] printIntArray(int[] value)
        {
            value[0] = 900;
            return value;
        }
        /*
         * 4.   Write a program name CountVowelsModularized that passes a
         * string to a method that returns the number of vowels in the string
         */
        static int[] CountVowelsModularized(string array)
        {
            int counter;
            int[] result = new int[1];
            for (int i = 0; i < array.Length; i++)
            {
                counter = 0;
                foreach (int item in array)
                {
                    if (item == 'a' ||
                        item == 'e' ||
                        item == 'i' ||
                        item == 'o' ||
                        item == 'u' ||
                        item == 'A' ||
                        item == 'E' ||
                        item == 'I' ||
                        item == 'O' ||
                        item == 'U')
                    {
                        counter++;
                    }
                }
                result[0] = counter;
            }

            return result;
        }
        /*
         * 5.    Program gets a quantity ordered from user  then determines
         * price and discount based on quantity
         * price per item before discounts is $6.00
         * order 15 or more, get a 20% discount
         * order 10 to 14 - get a 14% discount
         * order 5 to 9, get a 10% discount
         */
        static void CalculateDiscount(int quentity, out double discount, out double result)
        {
            double price = 6;
            if (quentity >= 5 && quentity <= 9)
            {
                discount = 10;
                result = price * quentity * ((100 - discount) / 100);
            }
            else if (quentity >= 10 && quentity <= 14)
            {
                discount = 14;
                result = price * quentity * ((100 - discount) / 100);
            }
            else if (quentity >= 15)
            {
                discount = 20;
                result = price * quentity * ((100 - discount) / 100);
            }
            else
            {
                discount = 0;
                result = price * quentity;
            }
        }
    }
}
