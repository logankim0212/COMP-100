using System;

namespace PartII
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /***Question01***/
            //DisplayHorizontalStars(0);
            //Console.WriteLine();
            //DisplayHorizontalStars(5);
            //Console.WriteLine();
            //DisplayHorizontalStars(10);
            /***Question02***/
            //DisplayVerticalStars(0);
            //Console.WriteLine(); 
            //DisplayVerticalStars(5);
            //Console.WriteLine(); 
            //DisplayVerticalStars(10);
            /***Question03***/
            //CalculateAndDisplayVolume(1);
            //CalculateAndDisplayVolume(2);
            //CalculateAndDisplayVolume(10);
            /***Question04***/
            //CalculateAndDisplayTax(10, "on");
            //CalculateAndDisplayTax(1, "On");
            //CalculateAndDisplayTax(20, "QC");
            //CalculateAndDisplayTax(100, "qC");
            //CalculateAndDisplayTax(25, "BC");
            /***Question05***/
            //CelsiusFarenheitTable(0);
            //CelsiusFarenheitTable(50);
            //CelsiusFarenheitTable(95);
            /***Question06***/
            //KMtoMilesTable(10, 1, 2);
            //KMtoMilesTable(1, .5, 5);
            //KMtoMilesTable(10, 10, 5);
            /***Question07***/
            //DisplaySineTable(0, .1, 5);
            //DisplaySineTable(.5, .05, 5);
            //DisplaySineTable(1, .1, 5);
            /***Question08***/
            //HeightConversion(90);
            //HeightConversion(120);
            //HeightConversion(275);
        }
        /*
         * 1.   Write a method called DisplayHorizontalStars(int numberOfStars).
         * This method will output the number of stars horizontally specified by
         * its argument. Call the DisplayHorizontalStars() method three times
         * from your program Main() method, supplying 0, 5 and 10 respectively
         * for the number of stars.
         */
        static void DisplayHorizontalStars(int numberOfStars)
        {
            int counter = 0;
            while (counter < numberOfStars)
            {
                Console.Write("*");
                counter++;
            }
        }
        /*2.    Write a method similar to the one above that displays a vertical
         * line of stars. 
         * Call this method three times with arguments 0, 5 and 10 respectively.
         */
        static void DisplayVerticalStars(int numberOfStars)
        {
            int counter = 0;
            while (counter < numberOfStars)
            {
                Console.WriteLine("*");
                counter++;
            }
        }
        /*3.   Write a method that accepts an argument of type double. The
         * method will calculate and display the volume of a sphere with radius
         * specified by its argument. [V=4/3  πr^3]. 
         * Call this method from your main three times, with arguments 1, 2,
         * and 10 respectively. The answers are 4.1888, 33.5103 and 4188.7902
         * respectively.
         * Use Math.PI for the value of π
         */
        static void CalculateAndDisplayVolume(double radius)
        {
            double volume;
            volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
            Console.WriteLine("A sphere of radius {0:f} will have a volume of {1:f}"
                              , radius, volume); 
        }
        /*
         * 4.   Write a method that takes two arguments: a cost price and a two
         * letter province code. It will calculate and display the selling
         * price. (If province is Ontario a tax of 13% is added to the price,
         * if the province is Quebec a tax of 17% is added to the cost price.
         * There is no tax for the rest of the provinces and territories). 
         * In your main, call this method enough times to fully test it
         */
        static void CalculateAndDisplayTax(double price, string code)
        {
            double tax;
            if (code.ToLower() == "on")
            {
                tax = price * 0.13;
                Console.WriteLine("The tax on an item {0:C} in {1} will be {2:C}"
                                  , price, code, tax); 
            }
            else if (code.ToLower() == "qc")
            {
                tax = price * 0.17;
                Console.WriteLine("The tax on an item {0:C} in {1} will be {2:C}"
                                  , price, code, tax); 

            }
            else if (code.Length > 2 || code.Length < 2)
            {
                Console.WriteLine("error"); 
            }
            else
            {
                Console.WriteLine("The tax on an item {0:C} in {1} will be 0"
                                  , price, code); 
            }
        }
        /*
         * 5.    Write a method that takes a single argument of type double.
         * The will display a Celsius to Fahrenheit conversion table. The
         * starting temperature is indicated by the argument and it will display
         * 10 lines in increments of 1. [Farenheit = 5/9 Celsius + 32]. 
         * In your main call this method two times, each time with a different
         * value.
         */
        static void CelsiusFarenheitTable(double celsius)
        {
            double fahrenheit;
            int counter = 0;
            while (counter < 10)
            {
                fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("{0} {1:f}", celsius, fahrenheit);
                celsius++;
                counter++;
            }
        }
        /*
         * 6.   Write a method that takes the following arguments: a starting
         * km value of type double, an increment size of type double and the
         * number of lines of type int. The display a kilometer to miles
         * conversion table. [miles = km * 0.621371]. 
         * In your main call this method three times, each time with
         * different values.
         */
        static void KMtoMilesTable(double km, double increment, int lines)
        {
            int counter = 0;
            double miles;
            while (counter < lines)
            {
                miles = km * 0.621371;
                Console.WriteLine("{0:f} {1:f}", km, miles); 
                km += increment;
                counter++;
            }
        }
        /*
         * 7.    Modify the DisplaySineTable() method in the previous section to
         * accept the start value, the step size and number of rows as argument 
         * to the method.
         */
        static void DisplaySineTable(double start, double increments, int rows)
        {
            double sine;
            int counter = 0;
            while (counter < rows)
            {
                sine = Math.Sin(start);
                Console.WriteLine("{0:f} {1:f}", start, sine);
                start += increments;
                counter++;
            }
        }
        /* 
         * 8.   Write a method that converts a person’s height from centimeter
         * to meters and centimeters and display the result on the console. 
         * In your main method, you should prompt the user for his height in
         * cm and then call the method with this value. 
         * Input   Result
         * 90cm    0m 90cm
         * 120cm   1m 20 cm
         * 275cm   2m 75cm
         */
        static void HeightConversion(double height)
        {
            double m, cm;
            m = height / 100;
            cm = height % 100;
            Console.WriteLine("{0}cm {1}m {2}cm", height, (int)m, cm); 
        }
    }
}
