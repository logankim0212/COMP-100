using System;

namespace Method_Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int number = 5;
            //Console.WriteLine("Before method call {0}", number);
            //BrokenTwice(number);
            //Twice(ref number);
            //Console.WriteLine("After method call {0}", number);
            double tax = CalculateTax(10);
            Console.WriteLine("Tax is {0:c}", tax); 
        }
        static void BrokenTwice(int a)
        {
            a *= 2;
            Console.WriteLine("In method {0}", a); 
        }
        static void Twice(ref int a)
        {
            a *= 2;
            Console.WriteLine("In method {0}", a); 
        }
        /*
         * 3.   Write a method with the following specifications:
         * name: CalculateTax
         * arguments: double representing the price of an item 
         * return value: double representing the tax of this item 
         * displays: nothing 
         * tasks: calculates and return the tax on this item. Tax =14% of price.
         * In your main you will call this method with a value of 10 and assign
         * the return value to a variable tax, then print the value of tax using
         * the currency specifier.
         */
        static double CalculateTax(double price)
        {

            return price * 0.14;
        }
    }
}
