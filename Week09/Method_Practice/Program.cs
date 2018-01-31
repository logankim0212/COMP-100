using System;

namespace Method_Practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //DisplayPersonalInformation();
            //DisplayAreaOfCircle(1);
            //DisplayAreaOfCircle(10);
            MathTable();
        }
        /*
         * Question 1
         * Write a method with the following specifications:
         * name: DisplayPersonalInformation
         * arguments: none
         * return value: none
         * tasks: displays your name, program and favorite course. 
         * Call this method from your main.
         */
        static void DisplayPersonalInformation()
        {
            Console.WriteLine("Logan Kim");
            Console.WriteLine("Software Engineering");
            Console.WriteLine("COMP 100");
        }

        /*
         * Question 2
         * Write a method with the following specifications:
         * name: DisplayAreaOfCircle
         * arguments: double representing the radius of the circle 
         * return value: none
         * tasks: calculates and display the area of the circle. Area = πr2
         * In your main you will call this method twice, with argument 1 and 10;
         */
        static void DisplayAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("A circle with radius of {0:f2} will have an area of {1:f2}", radius, area);
        }

        /*
         * Mathe Practice
         * Write a method to display a table of values of
         * y = sin(x) + 3tan(x) - 0.035
         * for x = 0 to 0.3 in 0.05 increments
         */
        static void MathTable()
        {
            for (double x = 0; x <= 0.3; x += 0.05)
            {
                double sin = Math.Sin(x);
                double tan = 3 * Math.Tan(x);
                double y = sin + tan - 0.035;
                Console.WriteLine("{0:f} {1:f} {2:f} {3,5:f}", x, sin, tan, y);  
            }
        }

    }
}
