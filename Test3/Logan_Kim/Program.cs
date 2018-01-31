using System;

namespace Logan_Kim
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                displayMenu();
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "1":
                        DemoQuestion3();
                        break;
                    case "2":
                        DemoQuestion4();
                        break;
                    case "3":
                        DemoQuestion5();
                        break;
                    case "4":
                        DemoQuestion6();
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid response");
                        break;
                }
            } while (choice.ToUpper() != "X");
        }
        #region Question 1 - 12 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * |------------------Programming I---------------------|
         * |           1. Working with array of doubles         |
         * |           2. Working with Hyperbolic functions     |
         * |           3. Calculate Kinetic Energy              |
         * |           4. Calculate Federal Tax                 |
         * |                                                    |
         * |           X. To exit the program                   |
         * |----------------------------------------------------|
         * Press the letter corresponding to your choice-> 
         * 
         */
        static void displayMenu()
        {
            Console.WriteLine("|---------------------Logan Kim----------------------|");
            Console.WriteLine("|           1. Working with array of doubles         |");
            Console.WriteLine("|           2. Working with Hyperbolic functions     |");
            Console.WriteLine("|           3. Calculate Kinetic Energy              |");
            Console.WriteLine("|           4. Calculate Federal Tax                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           X. To exit the program                   |");
            Console.WriteLine("|----------------------------------------------------|");
            Console.Write("Press the letter corresponding to your choice-> "); 
        }
        #endregion

        #region Question 2 - 26 marks
        /* 
         * In your Main() method, using a suitable looping structure, write the 
         * code to call this method repeatedly. 
         * Using a suitable branching structure, write the code to implement the 
         * following required functionality for all valid responses.
         * Valid responses includes both upper and lower case of the input. The 
         * following must be implemented:
         * 1 will call the DemoQuestion3() method
         * 2 will call the DemoQuestion4() method
         * 3 will call the DemoQuestion5() method
         * 4 will call the DemoQuestion6() method
         * X will terminate the program
         * Any other key will produce an error message
         * 
         * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
         */
        #endregion

        #region Question 3 - 36 marks
        /* Question 3c (10 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayLargeDoublesOnly
         * arguments: array of double
         * returns  : nothing
         * display  : only the items that are greater than 0.6
         * task     : use a suitable looping structure to send each
         *            suitable item to the screen.
         *            
         * YOU MUST USE A FOR loop
         */
        static void DisplayLargeDoublesOnly(double[] toPrint)
        {
            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] > 0.6)
                {
                    Console.Write("{0:F} ", toPrint[i]);
                }
            }
        }
        /* Question 3b (8 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayDoubleArray
         * arguments: array of double
         * returns  : nothing
         * display  : all the items in the array separated by a space
         * task     : use a suitable looping structure to send each
         *            item to the screen.
         * 
         * YOU MUST USE A FOREACH loop
         */
        static void DisplayDoubleArray(double[] toPrint)
        {
            foreach (double i in toPrint)
            {
                Console.Write("{0:F} ", i);
            }
        }
        /* Question 3a (11 marks)
         * 
         * Write a method with the following specification
         * name     : GenerateDoubleArray
         * arguments: int representing the number of items to generate
         *            i.e. the size of the resulting array
         * returns  : double array
         * display  : nothing
         * task     : 1) create the random object to generate random numbers
         *            2) declare and allocate storage for the array
         *            3) using a suitable looping structure get a random value 
         *               and assign it the element of the array
         *               use random.NextDouble() to obtain a random double
         *            4) return the array
         */
        static double[] GenerateDoubleArray(int NumberofItems)
        {
            Random random = new Random();
            double[] result = new double[NumberofItems];
            int counter = 0;
            do
            {
                result[counter++] = random.NextDouble();
            } while (counter < NumberofItems);
            return result;
        }
        /* The driver for question 3 (7 marks)
         * 
         * 1) Call GenerateDoubleArray with argument 32 and assign the 
         *    returned value to a suitable variable
         * 2) Use DisplayDoubleArray to print the above stored value
         * 3) Print an empty line
         * 4) Use DisplayLargeDoublesOnly to print only items greater than 0.6
         */
        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            double[] result = GenerateDoubleArray(32);
            DisplayDoubleArray(result);
            Console.WriteLine();
            Console.WriteLine();
            DisplayLargeDoublesOnly(result);
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        #endregion

        #region Question 4 - 14 marks
        /* Question 4 (8 marks)
         * 
         * Write a method with the following specification
         * name     : HyperBolic
         * arguments: an double representing the angle to convert
         *            an double to store the sinh value
         *            an double to store the cosh value
         *            an double to store the tanh value
         * returns  : nothing
         * display  : nothing
         * task     : uses the first argument to compute the other three values
         *           
         * hint     : use Math.Sinh, math.Cosh and Math.Tanh to compute the second,
         *            third and fourth arguments respectively
         */
        static void HyperBolic(double angle, out double sinh, out double cosh, out double tanh)
        {
            sinh = Math.Sinh(angle);
            cosh = Math.Cosh(angle);
            tanh = Math.Tanh(angle); 
        }
        /* The driver for question 4 (6 marks) 
         * 
         * Create the table as shown in the solution
         */
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            Console.WriteLine("   angle    sinh     cosh     tanh");
            double sinh, cosh, tanh;
            for (double angle = 0; angle <= 0.6; angle += 0.15)
            {
                HyperBolic(angle, out sinh, out cosh, out tanh);
                Console.WriteLine("  {0:F4}   {1:F4}   {2:F4}   {3:F4}", angle, sinh, cosh, tanh); 
            }
            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        #endregion

        #region Question 5 - 10 marks
        /* Question 5 (6 marks)
         * 
         * The kinetic energy of a moving object is the product of mass and the square of the velocity. 
         * (See the word document "Equations.doc" for the formulae.) 
         * 
         * Write a method that calculates and returns the kinetic energy of a moving object. 
         * The specifications is as follows:
         * 
         * Name: 
         *  CalculateKineticEnergy
         *  
         * Argument: 
         *  a double representing the mass of the object
         *  a double representing the speed of the object
         *  
         * Returns:
         *  a double indicating the energy by virtue of its motion
         *  
         * Action:
         *  Calculates and return the kinetic enrgy of the body.
         *  
         * Displays: 
         *  nothing.
         * 
         */
        static double CalculateKineticEnergy(double mass, double speed)
        {
            double energy = mass * Math.Pow(speed, 2) / 2;
            return energy;
        }
        /* The driver for question 5 (4 mark)
         * 
         * 1) Declare two variables of type double and initialize it to 1 and 1
         * 2) Invoke the method with these variable and display the resulting value
         * 3) change the variables to 5 and 3 and repeate Step 2.
         */
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            double mass, speed, energy;
            mass = 1;
            speed = 1;
            energy = CalculateKineticEnergy(mass, speed);
            Console.WriteLine("A body of mass {0:F1}kg moving at {1:F1}mps will have kinetic energy of {2:F1}J", mass, speed, energy);
            mass = 5;
            speed = 3;
            energy = CalculateKineticEnergy(mass, speed);
            Console.WriteLine("A body of mass {0:F1}kg moving at {1:F1}mps will have kinetic energy of {2:F1}J", mass, speed, energy); 
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        #endregion

        #region Question 6 - 19 marks
        /* Question 6 (13 marks)
         * 
         * All Canadian are required to pay federal and provincial taxes. This question deals 
         * with federal tax calculation. The question specification are as follows:
         * 
         * Name: 
         *  CalculateFederalTax
         *  
         * Argument: 
         *  a double representing the annual taxable income
         *  
         * Returns:
         *  a double indicating the federal tax owned to the government 
         *    
         * Action:
         *  Calculates and return the tax based on the following abridge table:
         *  15% on the first $45,282 of taxable income, +
         *  20.5% on the next $45,281 of taxable income (on the portion of taxable income over $45,282 up to $90,563), +
         *  33% of taxable income over $90,563.
         *  
         * Displays: nothing.
         *         
         */
        static double CalculateFederalTax(double income)
        {
            double tax;
            if (income > 0 && income <= 45_282)
            {
                tax = income * 0.15;
            }
            else if (income <= 90_563)
            {
                tax = 0.15 * 45_282 + 0.205 * (income - 45_282);
            }
            else if (income > 90_563)
            {
                tax = 0.15 * 45_282 + 0.205 * (90_563 - 45_282) + 0.33 * (income - 90_563);
            }
            else
            {
                tax = 0;
            }
            return tax;
        }
        /* The driver for question 6 (6 marks)
         * 
         * 1) Declare a double variable and initialized it to 45,000
         * 2) Invoke the CalculateFederalTax method with this variable and print the returned value
         * 3) Change the variable to 75,000 and repeat step 2
         * 4) Change the variable to 115,000 and repeat step 2
         */
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            double income, tax;
            income = 45_000;
            tax = CalculateFederalTax(income);
            Console.WriteLine("Your federal tax will be {0:C} if your income is {1:C}", tax, income);
            income = 75_000;
            tax = CalculateFederalTax(income);
            Console.WriteLine("Your federal tax will be {0:C} if your income is {1:C}", tax, income);
            income = 115_000;
            tax = CalculateFederalTax(income);
            Console.WriteLine("Your federal tax will be {0:C} if your income is {1:C}", tax, income);
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
        #endregion
    }
}