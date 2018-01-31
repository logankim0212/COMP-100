using System;

namespace PartIV
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
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine("| 1. Double It                       |");
            Console.WriteLine("| 2. Cube It                         |");
            Console.WriteLine("| 3. Calculate Tuition Fee           |");
            Console.WriteLine("| 4. Sum and Difference              |");
            Console.WriteLine("| 5. Calculate Trig Values           |");
            Console.WriteLine("| 6. Sine Cosine                     |");
            Console.WriteLine("| 7. Find Two Solutions              |");
            Console.WriteLine("| 0. End program                     |");
            Console.WriteLine("+------------------------------------+");
            Console.Write("     Enter your choice -> ");
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
                        int val;
                        val = 5;
                        Console.Write("Before method call: {0} ", val);
                        DoubleIt(ref val);
                        Console.WriteLine("after method call: {0}", val);
                        val = 7;
                        Console.Write("Before method call: {0} ", val);
                        DoubleIt(ref val);
                        Console.WriteLine("after method call: {0}", val);
                        break;
                    case "2":
                        int val2;
                        val2 = 5;
                        Console.Write("Before method call: {0} ", val2);
                        CubeIt(val2,ref val2);
                        Console.WriteLine("after method call: {0}", val2);
                        val2 = 2;
                        Console.Write("Before method call: {0} ", val2);
                        CubeIt(val2, ref val2);
                        Console.WriteLine("after method call: {0}", val2);
                        break;
                    case "3":
                        int number;
                        double cost;
                        number = 5;
                        cost = 500;
                        Console.Write("{0} courses @{1:C} ", number, cost);
                        CalculateTuitionFee(number, cost, ref cost);
                        Console.WriteLine("will cost {0:C}", cost);
                        number = 5;
                        cost = 450;
                        Console.Write("{0} courses @{1:C} ", number, cost);
                        CalculateTuitionFee(number, cost, ref cost);
                        Console.WriteLine("will cost {0:C}", cost);
                        number = 10;
                        cost = 450;
                        Console.Write("{0} courses @{1:C} ", number, cost);
                        CalculateTuitionFee(number, cost, ref cost);
                        Console.WriteLine("will cost {0:C}", cost);
                        number = 10;
                        cost = 350;
                        Console.Write("{0} courses @{1:C} ", number, cost);
                        CalculateTuitionFee(number, cost, ref cost);
                        Console.WriteLine("will cost {0:C}", cost);
                        break;
                    case "4":
                        int a4, b4;
                        a4 = 10;
                        b4 = 15;
                        Console.Write("a:{0}, b:{1},  ", a4, b4);
                        SumAndDifference(a4, b4, ref a4, ref b4);
                        Console.WriteLine("sum: {0}, diff: {1}", a4, b4);
                        a4 = 25;
                        b4 = 15;
                        Console.Write("a:{0}, b:{1},  ", a4, b4);
                        SumAndDifference(a4, b4, ref a4, ref b4);
                        Console.WriteLine("sum: {0}, diff: {1}", a4, b4);
                        a4 = 25;
                        b4 = 25;
                        Console.Write("a:{0}, b:{1},  ", a4, b4);
                        SumAndDifference(a4, b4, ref a4, ref b4);
                        Console.WriteLine("sum: {0}, diff: {1}", a4, b4);
                        break;
                    case "5":
                        double angle, sin, cos, tan;
                        angle = 0;
                        Console.WriteLine("   Angle  Sine     Cosine   Tangent");
                        while (angle <= 95)
                        {
                            CalculateTrigValues(angle, out sin, out cos, out tan);
                            Console.WriteLine("  {0,5:F}   {1,6:F4}  {2,7:F4} {3,8:F4}"
                                             , angle, sin, cos, tan);
                            angle+=5;
                        }
                        break;
                    case "6":
                        double angle6, sine, cosine;
                        angle6 = 0.5;
                        Console.WriteLine("   Angle  Sine     Cosine");
                        while (angle6 <= 0.509)
                        {
                            SineCosine(angle6, out sine, out cosine);
                            Console.WriteLine("   {0,5:F3}  {1,6:F4}  {2,7:F4}"
                                             , angle6, sine, cosine);
                            angle6 += 0.001;
                        }
                        break;
                    case "7":
                        double a7, b7, c7, s1, s2;
                        a7 = 12;
                        b7 = 1;
                        c7 = -6;
                        FindTwoSolutions(a7, b7, c7, out s1, out s2);
                        Console.WriteLine("equation {0}x^2 + {1}x + {2} will have " +
                                          "roots {3:f3} and {4:f3}", a7, b7, c7, s1, s2); 
                        break;
                }
            } while (choice != "0");
        }
        /*
         * 1.   Write a method call DoubleIt(ref int x) that takes a single
         * argument and does not return a value. This method will double the 
         * value of its argument. 
         * In your main, call this method twice and print the value of the
         * parameter after the method call.
         */
        static void DoubleIt(ref int x)
        {
            x = x * 2;
        }
        /*
         * 2.   Write a method call CubeIt(int x, ref int cube) that takes two
         * arguments and does not return a value. The method will cube the
         * first argument and assign it to the second argument. 
         * In your main, call this method twice and print the value of the
         * parameters after each method call.
         */
        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
        /*
         * 3.   Write a method with the following header: static void
         * CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref
         * double fees). This method will calculate and assign the required
         * fees amount to the third argument. [Fees = number of courses *
         * cost per course + 15.25]. From your program Main() method,
         * call the CalculateTuitionFee () method four times supplying
         * different arguments each time and display the value of the third
         * argument after each method call.
         */
        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse,
                                        ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }
        /*
         * 4.   Write a method that takes four parameter of type int. The 
         * method will assign the sum of the first two arguments to the third 
         * and the difference of the first two to the fourth. This method 
         * should be coded so that the calling method will use the value of the
         * third and fourth parameters. Call this method about three times and
         * print out the value of the four parameters after each method call.
         */
        static void SumAndDifference(int a, int b, ref int sum, ref int diff)
        {
            sum = a + b;
            diff = Math.Abs(a - b); 
        }
        /*
         * 5.   Write a method with header static void CalculateTrigValues
         * (double degrees, out double sine, out double cosine, out double
         * tangent). The method will use the first argument to compute the 
         * values of the other three arguments. Used the method Math.Sin,
         * Math.Cos and Math.Tan to compute the second to fourth arguments
         * respectively. [radians = degrees * Math.Pi /180]. 
         * In the Main() method, invoke this method 20 times with the first
         * argument taking the values 0, 5, 10, … 95 and display the four
         * arguments in a professional tabular format.
         */
        static void CalculateTrigValues(double degrees, out double sine,
                                        out double cosine, out double tangent)
        {
            double radians;
            radians = degrees * Math.PI / 180;
            sine = Math.Sin(radians);
            cosine = Math.Cos(radians);
            tangent = Math.Tan(radians); 
        }
        /*
         * 6.   Write a method that takes three parameters of type double: the
         * first represents an angle, the other two represents the sine and 
         * cosine of the angle respectively. The method must be able to change
         * the actual value of the second and third argument. In your Main()
         * method, call this method ten times with values 0.500, 0.501, 0.502
         * … 0.509 and printout the values for angle, sine and cosine in a 
         * tabular format
         */
        static void SineCosine (double angle, out double sin, out double cos)
        {
            sin = Math.Sin(angle);
            cos = Math.Cos(angle); 
        }
        /*
         * 7.   A quadratic equation is one in the form of ax2+bx+c = 0.
         * Normally, there are two solutions to such equations given by the
         * expression x=(-b∓√(b^2-4ac))/2a.The Write a method that takes five
         * double arguments, the first three represents a, b and c respectively
         * and the last two the solutions to the equation. [You can check your
         * implementation, the quadratic equation 12x2+x-6 will yield solutions
         * -0.750 & 0.667]
         */
        static void FindTwoSolutions(double a, double b, double c, out double s1, out double s2)
        {
            s1 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            s2 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        }
    }
}
