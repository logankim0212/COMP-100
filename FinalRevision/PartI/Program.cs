using System;

namespace PartI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ShowMenu();
        }
        /* 1.   Write a method called DisplayPersonalInfo(). This method will
         * display your name, school, program and your favorite course.
         * Call the DisplayPersonalInfo() method from your program Main() method
         */
        static void DisplayPersonalInfo()
        {
            Console.WriteLine("Logan Junhwi Kim");
            Console.WriteLine("Centennial College"); 
            Console.WriteLine("Software Engineering Technology"); 
            Console.WriteLine("COMP100"); 
        }
        /*
         * 2.   Write a method called CalculateTuition(). This method will
         * prompt the user for the number of courses that she is currently
         * taking and then calculate and display the tuition cost.
         * (cost = number of course * 569.99). Call the CalculateTuition()
         * method two times from the same Main() method as in question 1.
         */
        static void CalculateTuition()
        {
            int course;
            double cost;
            Console.Write("How many courses are you taking? ");
            course = Convert.ToInt32(Console.ReadLine());
            cost = course * 569.99;
            Console.WriteLine("The cost of {0} courses is {1:c}", course, cost);
        }
        /*
         * 3.   Write a method call CalculateAreaOfCircle(). This method will
         * prompt the user for the radius of a circle and then calculate and
         * display the area.[A = πr2]. 
         * Call the CalculateAreaOfCircle() method twice from the same Main()
         * method as in question 1. Use Math.Pi for the value of π
         */
        static void CalculateAreaOfCircle()
        {
            double radius, area;
            Console.Write("Enter the radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = 2 * Math.PI * radius;
            Console.Write("If the radius is {0:f} the area will be {1:f}"
                          , radius, area);
        }
        /*
         * 4.   Write a method call CalculateAreaOfTriangle(), that prompts
         * the user for the base and height of a triangle and then calculate
         * and display the area.[ A=bt/2 ] 
         * Call the CalculateAreaOfTriangle() method twice from the same Main()
         * method as in question 1.
         */
        static void CalculateAreaOfTriangle()
        {
            double height, Base, area;
            Console.Write("Height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            area = Base * height / 2;
            Console.Write("The area will be {0:f}", area);
        }
        /* 
         * 5.   Write a method call CalculateSaleCommission(), that prompts
         * the user for his sales figure, and then calculate and display his
         * commission. (commission = 25% of sales in excess of 1000. If sales 
         * is equal to or below $1000.00 there is no commission) 
         * Call the CalculateSaleCommission() method three times from the 
         * same Main() method as in question 1.
         */
        static void CalculateSaleCommission()
        {
            double amount, commission;
            Console.Write("What is your sales amount? ");
            amount = Convert.ToDouble(Console.ReadLine());
            if (amount > 1000)
            {
                commission = amount * 0.25;
            }
            else
            {
                commission = 0;
            }
            Console.Write("The commission on {0:c} is {1:c}", amount, commission);
        }
        /*
         * 6.   Write a method call DisplaySineTable(), that prompts the user
         * for a starting value and an step size. The method will calculate
         * and display a table (10 rows) of sine values based on the user input.
         * Use the built-in method Math.Sin() to obtain the sine of an angle.
         * e.g. if the starting value is 0.5 and the step size is 0.03 the
         * method will display the following table:
         * 0.50    0.4794
         * 0.53    0.5055
         * 0.56    0.5311
         * 0.77    0.6961
         * The numbers in both columns MUST be right aligned. Call the
         * DisplaySineTable() method from the same Main() method as in
         * question 1.
         */
        static void DisplaySineTable()
        {
            double start, increment, sine;
            int counter = 0;
            Console.Write("Starting value: ");
            start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Increment value: ");
            increment = Convert.ToDouble(Console.ReadLine());
            while (counter < 10)
            {
                sine = Math.Sin(start);
                Console.WriteLine("{0:f} {1:f3}", start, sine);
                start += increment;
                counter++;
            }
        }
        /* 7.   In a write a method called DisplayMenu() to display the
         * following text on screen:
         * =============Narendra’s Computer Systems==================
         * |         1. Display Personal Information                |
         * |         2. Calculate Tuition                           |
         * |         3. Calculate Area Of A Circle                  |
         * |         4. Calculate The Area Of A Triangle            |
         * |         5. Calculate Sales Commission                  |
         * |         6. Display Sine Table                          |
         * |         0. End program                                 |
         * |                                                        |
         * ==========================================================
         *           Enter the number of your choice ->
         * You may replace the instructor’s name with your name.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("============= Logan’s Computer Systems =====================");
            Console.WriteLine("|         1.Display Personal Information                   |");
            Console.WriteLine("|         2.Calculate Tuition                              |");
            Console.WriteLine("|         3.Calculate Area Of A Circle                     |");
            Console.WriteLine("|         4.Calculate The Area Of A Triangle               |");
            Console.WriteLine("|         5.Calculate Sales Commission                     |");
            Console.WriteLine("|         6.Display Sine Table                             |");
            Console.WriteLine("|         0.End program                                    |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("============================================================");
            Console.Write("          Enter the number of your choice -> ");
        }
        /*
         * 8.   Add another method called ShowMenu() to your project. This
         * method will call the method in question 7 continuously until the
         * user presses 0. (You will have to invoke the method in a loop body,
         * read in the user input as well as check the input). You will need to
         * hook up all the methods that you wrote previously i.e. questions
         * 1 to 6. Remove all the code from your Main() method and add a single
         * call to the ShowMenu() method.
         */
        static void ShowMenu()
        {
            string number;
            do
            {
                DisplayMenu();
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        DisplayPersonalInfo();
                        break;
                    case "2":
                        CalculateTuition();
                        break;
                    case "3":
                        CalculateAreaOfCircle();
                        break;
                    case "4":
                        CalculateAreaOfTriangle();
                        break;
                    case "5":
                        CalculateSaleCommission();
                        break;
                    case "6":
                        DisplaySineTable();
                        break;
                }
            } while (number != "0");
        }
    }
}
