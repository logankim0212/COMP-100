using System;

namespace PartIII
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
            Console.WriteLine("+-------------------------------------+");
            Console.WriteLine("| 1.  Calculate Difference            |");
            Console.WriteLine("| 2.  Calculate Power                 |");
            Console.WriteLine("| 3.  Calculate Tuition Fee           |");
            Console.WriteLine("| 4.  Calculate Commission            |");
            Console.WriteLine("| 5.  Get Burget Cost                 |");
            Console.WriteLine("| 6.  Calculate Gravitational Force   |");
            Console.WriteLine("| 7.  Heron Formula                   |");
            Console.WriteLine("| 8.  Convert Celsius To Fahrenheit   |");
            Console.WriteLine("| 9.  Convert Fahrenheit To Celsius   |");
            Console.WriteLine("| 10. Convert Celsius To Kelvin       |");
            Console.WriteLine("| 11. Convert Fahrenheit To Celsius   |");
            Console.WriteLine("| 12. Square of Cube                  |");
            Console.WriteLine("| 13. Sales Commission                |");
            Console.WriteLine("| 0. End program                      |");
            Console.WriteLine("+-------------------------------------+");
            Console.Write("      Enter your choice -> ");
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
                        int first, second, q1;
                        first = 3;
                        second = 5;
                        q1 = CalculateDifference(first, second);
                        Console.WriteLine("The difference between {0} and {1} is {2}"
                                          , first, second, q1);
                        first = 13;
                        second = 5;
                        q1 = CalculateDifference(first, second);
                        Console.WriteLine("The difference between {0} and {1} is {2}"
                                          , first, second, q1);
                        first = 23;
                        second = 5;
                        q1 = CalculateDifference(first, second);
                        Console.WriteLine("The difference between {0} and {1} is {2}"
                                          , first, second, q1);
                        first = 23;
                        second = 13;
                        q1 = CalculateDifference(first, second);
                        Console.WriteLine("The difference between {0} and {1} is {2}"
                                          , first, second, q1);
                        break;
                    case "2":
                        double c, r, q2;
                        c = 1;
                        r = 1.5;
                        q2 = CalculatePower(c, r);
                        Console.WriteLine("if current is {0:f}A and Resistance " +
                                          "is {1:f}ohms then power will be {2:f}W"
                                          , c, r, q2);
                        c = .1;
                        r = 100;
                        q2 = CalculatePower(c, r);
                        Console.WriteLine("if current is {0:f}A and Resistance " +
                                          "is {1:f}ohms then power will be {2:f}W"
                                          , c, r, q2);
                        break;
                    case "3":
                        int number;
                        double cost, q3;
                        number = 1;
                        cost = 500;
                        q3 = CaculateTuitionFee(number, cost);
                        Console.WriteLine("{0} courses @{1:C} will cost a total of {2:C}"
                                         , number, cost, q3);
                        number = 5;
                        cost = 450;
                        q3 = CaculateTuitionFee(number, cost);
                        Console.WriteLine("{0} courses @{1:C} will cost a total of {2:C}"
                                         , number, cost, q3);
                        number = 5;
                        cost = 450;
                        q3 = CaculateTuitionFee(number, cost);
                        Console.WriteLine("{0} courses @{1:C} will cost a total of {2:C}"
                                         , number, cost, q3);
                        number = 5;
                        cost = 0;
                        q3 = CaculateTuitionFee(number, cost);
                        Console.WriteLine("{0} courses @no cost supplied will" +
                                          " cost a total of {1:C}", number, q3);
                        break;
                    case "4":
                        double amount, q4;
                        amount = 900;
                        q4 = CalculateCommission(amount);
                        Console.WriteLine("A sale amount of {0:C} will yield" +
                                          " a commission of {1:C}", amount, q4);
                        amount = 1000;
                        q4 = CalculateCommission(amount);
                        Console.WriteLine("A sale amount of {0:C} will yield" +
                                          " a commission of {1:C}", amount, q4);
                        amount = 2000;
                        q4 = CalculateCommission(amount);
                        Console.WriteLine("A sale amount of {0:C} will yield" +
                                          " a commission of {1:C}", amount, q4);
                        break;
                    case "5":
                        Console.WriteLine("First call gives {0:C}", GetBurgerCost());
                        Console.WriteLine("Second call gives {0:C}", GetBurgerCost());
                        break;
                    case "6":
                        double earth, moon, distance, force;
                        earth = 5.972e24;
                        moon = 7.348e22;
                        distance = 3.844e8;
                        force = CalculateGravitationalAttraction(earth, moon, distance);
                        Console.WriteLine("earth:{0:E}", earth);
                        Console.WriteLine("moon:{0:E}", moon);
                        Console.WriteLine("distance:{0:E}", distance);
                        Console.WriteLine("force:{0:E}", force);
                        break;
                    case "7":
                        double a, b, c7, area;
                        a = 5.83;
                        b = 4.24;
                        c7 = 8;
                        area = HeronFormula(a, b, c7);
                        Console.WriteLine("a:{0:F} b:{1:F} c:{2:F} area:{3:F}", a, b, c7, area);
                        break;
                    case "8":
                        double cel, fah;
                        cel = 0;
                        fah = ConvertCelsiusToFahrenheit(cel);
                        Console.WriteLine("c:{0:F} f:{1:F}", cel, fah);
                        cel = 50;
                        fah = ConvertCelsiusToFahrenheit(cel);
                        Console.WriteLine("c:{0:F} f:{1:F}", cel, fah);
                        cel = 100;
                        fah = ConvertCelsiusToFahrenheit(cel);
                        Console.WriteLine("c:{0:F} f:{1:F}", cel, fah);
                        break;
                    case "9":
                        double fah9, cel9;
                        fah9 = 0;
                        cel9 = ConvertFahrenheitToCelsius(fah9);
                        Console.WriteLine("F:{0:F} C:{1:F}", fah9, cel9);
                        fah9 = 32;
                        cel9 = ConvertFahrenheitToCelsius(fah9);
                        Console.WriteLine("F:{0:F} C:{1:F}", fah9, cel9);
                        fah9 = 212;
                        cel9 = ConvertFahrenheitToCelsius(fah9);
                        Console.WriteLine("F:{0:F} C:{1:F}", fah9, cel9);
                        break;
                    case "10":
                        double cel10, kel;
                        cel10 = -196;
                        kel = ConvertCelsiusToKelvin(cel10);
                        Console.WriteLine("C:{0:F} K:{1:F}", cel10, kel);
                        cel10 = 0;
                        kel = ConvertCelsiusToKelvin(cel10);
                        Console.WriteLine("C:{0:F} K:{1:F}", cel10, kel);
                        cel10 = 100;
                        kel = ConvertCelsiusToKelvin(cel10);
                        Console.WriteLine("C:{0:F} K:{1:F}", cel10, kel);
                        break;
                    case "11":
                        double fah11, kel11;
                        fah11 = -196;
                        kel11 = ConvertFahrenheitToKelvin(fah11);
                        Console.WriteLine("F:{0:F} K:{1:F}", fah11, kel11);
                        fah11 = 0;
                        kel11 = ConvertFahrenheitToKelvin(fah11);
                        Console.WriteLine("F:{0:F} K:{1:F}", fah11, kel11);
                        fah11 = 100;
                        kel11 = ConvertFahrenheitToKelvin(fah11);
                        Console.WriteLine("F:{0:F} K:{1:F}", fah11, kel11);
                        break;
                    case "12":
                        int a12;
                        a12 = Square();
                        Console.WriteLine("Original number:{0}, after cubing the square: {1}"
                                          , Math.Sqrt(a12), Cube(a12));
                        break;
                    case "13":
                        double a13, b13;
                        a13 = DailySalesAmount();
                        b13 = Commission(a13);
                        Console.WriteLine("Your commission for the sales of {0:C} is {1:C}", a13, b13); 
                        break;
                }
            } while (choice != "0");
        }
        /*
         * 1.   Write a method called CaculateDifference(int firstNumber, int
         * secondNumber). This method will calculate and return the difference
         * between the two numbers i.e. it will subtract the smaller one from the
         * larger one and then return that value. 
         * Call the CaculateDifference() method four times from your program Main()
         * method supplying different arguments each time. You must display the
         * returned value for each call.
         */
        static int CalculateDifference(int firstNumber, int secondNumber)
        {
            int answer;
            answer = Math.Abs(firstNumber - secondNumber);
            return answer;
        }
        /*
         * 2.   Write a method called CalculatePower(double current, double
         * resistance). The method will calculate and return the electrical
         * power dissipated in a circuit. [P=(I^2)R].
         * Call the CalculatePower() method two times from your program Main()
         * method supplying different arguments each time and displaying the
         * returned value each time.
         */
        static double CalculatePower(double current, double resistance)
        {
            double power;
            power = Math.Pow(current, 2) * resistance;
            return power;
        }
        /*
         * 3.   Write a method called CaculateTuitionFee(int numberOfCourses,
         * double costPerCourse = 449.99). This method will calculate and
         * return the required fees amount. [Fees = number of courses * cost
         * per course + 15.25]. 
         * Call the CaculateTuitionFee() method four times from your program
         * Main() method supplying different arguments each time.
         */
        static double CaculateTuitionFee(int numberOfCourses, double costPerCourse)
        {
            double tuition;
            tuition = numberOfCourses * costPerCourse + 15.25;
            return tuition;
        }
        /*
         * 4.   Write a method called CalculateCommission(double saleAmount).
         * This method will calculate and return a sales representation’s
         * commission. [over $1000 the commission will be 1%]. 
         * Call the CalculateCommission() method three times from your program
         * Main() method, supplying arguments 900, 1000 and 2000.
         */
        static double CalculateCommission(double saleAmount)
        {
            double commission;
            if (saleAmount > 1000)
            {
                commission = saleAmount * 0.01;
            }
            else
            {
                commission = 0;
            }
            return commission;
        }
        /*
         * 5.   Write a method that does not take any argument. The method
         * will prompt the user for the number of burgers that he wants to buy.
         * The method will calculate and return the amount of money that will
         * be required. [One burger cost $1.39]. 
         * From your program Main() method, call the above method two times
         */
        static double GetBurgerCost()
        {
            int burgers;
            double cost;
            Console.Write("How many burgers? ");
            burgers = Convert.ToInt32(Console.ReadLine());
            cost = burgers * 1.39;
            return cost;
        }
        /*
         * 6.   “Newton's law of universal gravitation states that every point
         * mass in the universe attracts every other point mass with a force
         * that is directly proportional to the product of their masses and
         * inversely proportional to the square of the distance between them.”
         * Write a method called CalculateGravitationalAttraction() that takes
         * three double arguments (masses of the two bodies and the distance
         * between them). The method will calculate and return the force of 
         * attraction between them. [F=G (m_1 m_2)/d^2, where G = 6.673x10-11]. 
         * In your main call this method with the masses of the earth, moon and
         * the distance between them and display the resulting force. Mass of
         * Earth = 5.972 × 1024, moon = 7.348 × 1022, Distance = 384,400000m.
         * [Answer 1.99 x 1020N] 
         */
        static double CalculateGravitationalAttraction(double m1, double m2, double d)
        {
            double f, g;
            g = 6.673e-11;
            f = (g * m1 * m2) / Math.Pow(d, 2);
            return f;
        }
        /*
         * 7.   Heron’s formula allows you to calculate the area of any triangle
         * given the length of the three sides. Write a method that takes the
         * length of the three sides and return the area of the specified 
         * triangle. A=√(s(s-a)(s-b)(s-c) ) where s=(a+b+c)/2. 
         * In your main call this method with arguments 5.83, 4.24 and 8.00,
         * and display the area. [Answer = 12.0].
         */
        static double HeronFormula(double a, double b, double c)
        {
            double area, s;
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        /*
         * 8.   Write a method called ConvertCelsiusToFahrenheit that takes a
         * double argument. The method will calculate and return the Fahrenheit
         * equivalent of the argument. [F = C * 9 / 5 + 32]. 
         * In your main call this method three times with arguments 0, 50 and
         * 100 respectively and display the results.
         */
        static double ConvertCelsiusToFahrenheit(double c)
        {
            double f;
            f = c * 9 / 5 + 32;
            return f;
        }
        /*
         * 9.   Write a method called ConvertFahrenheitToCelsius that takes a
         * double argument. The method will calculate and return the Celsius
         * equivalent of the argument. [C = (F – 32) * 5 / 9]. 
         * In your main call this method three times with arguments 0, 32 and
         * 212 respectively and display the results.
         */
        static double ConvertFahrenheitToCelsius(double f)
        {
            double c;
            c = (f - 32) * 5 / 9;
            return c;
        }
        /*
         * 10.  Write a method called ConvertCelsiusToKelvin that takes a
         * double argument. The method will calculate and return the Kelvin
         * equivalent of the argument. [K = C + 273.15]. 
         * In your main call this method three times with arguments -196,
         * 0 and 100 respectively and display the results.
         */
        static double ConvertCelsiusToKelvin(double c)
        {
            double k;
            k = c + 273.15;
            return k;
        }
        /*
         * 11.  Write a method call ConvertFahrenheitToKelvin that takes a 
         * double argument. The method will calculate and return the Kelvin
         * equivalent of the argument. [Use the two previous methods to assist
         * in your computation]. 
         * In your main call this method three times and display the results.
         */
        static double ConvertFahrenheitToKelvin(double f)
        {
            double kel;
            kel = ConvertCelsiusToKelvin(ConvertFahrenheitToCelsius(f));
            return kel;
        }
        /*
         * 12.  Write two methods: Square(int) and Cube(int), these methods
         * return the square and the cube of its argument. In your main method
         * prompt the user for an integer, then pass this integer to the Square
         * method and then pass the results to the Cube method. In the main
         * method print out the final results.
         */
        static int Square()
        {
            int a, b;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine()); 
            b = a * a;
            return b;
        }
        static int Cube(int a)
        {
            int b;
            b = a * a * a;
            return b;
        }
        /*
         * 13.  Write two methods that will be called from main. The first
         * method should prompt the user for his daily sales amount. The method
         * should accept and return this amount. The second method should
         * calculate and return his commission based on the following: 0-999 3%,
         * 1000-2999 4% and over 3000 5%. In your main call the two methods and 
         * display the results in a readable manner 
         */
        static double DailySalesAmount()
        {
            double sales;
            Console.Write("Enter your daily sales amount: ");
            sales = Convert.ToDouble(Console.ReadLine());
            return sales;
        }
        static double Commission(double sales)
        {
            double comm;
            if (sales >= 0 && sales < 1000)
            {
                comm = sales * 0.03;
            }
            else if (sales < 3000)
            {
                comm = sales * 0.04;
            }
            else if (sales >= 3000)
            {
                comm = sales * 0.05;
            }
            else
            {
                comm = 0;
            }
            return comm;
        }
    }
}
