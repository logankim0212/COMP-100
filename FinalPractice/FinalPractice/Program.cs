using System;

namespace FinalPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input;
            do
            {
                displayMenu();
                input = Console.ReadLine().ToUpper();
                switch(input)
                {
                    case "A":
                        DemoQuestion3();
                        break;
                    case "B":
                        DemoQuestion4();
                        break;
                    case "C":
                        DemoQuestion5();
                        break;
                    case "D":
                        DemoQuestion6();
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            } while (input != "X");
        }   
        #region Question 1 - 12 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * +---------------------COMP100------------------------+
         * |           a) Working with array of integer         |
         * |           v) Volume Conversion                     |
         * |           p) Photo Electric Effect                 |
         * |           t) Calculate Federal Tax                 |
         * |                                                    | 
         * |           x) To exit the program                   |
         * +----------------------------------------------------+
         * Press the letter corresponding to your choice-> ");
         * 
         */
        static void displayMenu ()
        {
            Console.WriteLine("+---------------------COMP100------------------------+");
            Console.WriteLine("|           a) Working with array of integer         |");
            Console.WriteLine("|           b) Volume Conversion                     |");
            Console.WriteLine("|           c) Photo Electric Effect                 |");
            Console.WriteLine("|           d) Calculate Federal Tax                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           x) To exit the program                   |");
            Console.WriteLine("+----------------------------------------------------+");
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
         * A will call the DemoQuestion3() method
         * B will call the DemoQuestion4() method
         * C will call the DemoQuestion5() method
         * D will call the DemoQuestion6() method
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
         * name     : DisplayOnlyEvenInt
         * arguments: array of int
         * returns  : nothing
         * display  : only the even items in the space
         * task     : use a suitable looping structure to send each
         *            even to the screen.
         * 
         * YOU MUST USE A FOR loop
         */
        static void DisplayOnlyEvenInt(int[] toPrint)
        {
            for (int i = 0; i < toPrint.Length; i++)
            {
                if (toPrint[i] % 2 ==0)
                {
                    Console.Write(toPrint[i] + " "); 
                }
            }
        }

        /* Question 3b (8 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayIntArray
         * arguments: array of int
         * returns  : nothing
         * display  : all the items in the array seperated by a single space
         * task     : use a suitable looping structure to send each
         *            item to the screen.
         *            
         * YOU MUST USE A FOREACH loop
         */
        static void DisplayIntArray(int[] toPrint)
        {
            foreach (int i in toPrint)
            {
                Console.Write(i + " ");
            }
        }

        /* Question 3a (11 marks)
         * 
         * Write a method with the following specification
         * name     : GenerateIntArray
         * arguments: int representing the number of ints to generate
         *            i.e. the size of the resulting array
         * returns  : int array
         * display  : nothing
         * task     : 1) create the random object to generate random numbers
         *            2) declare and allocate storage for the array
         *            3) using a suitable looping structure get a random value 
         *               and assign it the element of the array
         *               use random.Next(10) to obtain a random int
         *            4) return the array
         */
        static int[] GenerateIntArray(int size)
        {
            Random random = new Random();
            int[] result = new int[size];
            int counter = 0;
            do
            {
                result[counter++] = random.Next(10);
            } while (counter < size);
            return result;
        }

        /* The driver for question 3 (7 marks)
         * 
         * 1) Call GenerateIntArray with argument 35 and assign the 
         *    returned value to a suitable variable
         * 2) Use DisplayIntArray to print the above stored value
         * 3) Print an empty line
         * 4) Use DisplayOnlyEvenInt to print only the even items in the 
         *    above stored value
         */
        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            //code for invoking question 3 goes here
            int[] result = GenerateIntArray(35);
            DisplayIntArray(result);
            Console.WriteLine();
            DisplayOnlyEvenInt(result);
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        #endregion

        #region Question 4 - 14 marks
        /* Question 4 (8 marks)
         * 
         * Write a method with the following specification
         * name     : VolumeConversion
         * arguments: an double representing the liter value to convert
         *            an double to store the milliliters
         *            an double to store the gallon
         *            an double to store the ounce
         * returns  : nothing
         * display  : nothing
         * task     : converts the first argument (liter amount) into 
         *            mils, gallons and ounces
         *           
         * hint     : 1 liter = 1000 mils                    
         *            1 liter = 0.2642 gallons
         *            1 liter = 33.8135 ounce
         */
        static void VolumeConversion(double liter, out double mils, out double gallons, out double ounces)
        {
            mils = 1000 * liter;
            gallons = 0.2642 * liter;
            ounces = 33.8135 * liter;
        }

         

        /* The driver for question 4 (6 marks) 
         * 
         * 1) Declare an int variable (this will be your first argument) 
         *    and initialized it to 1
         * 2) Declare three other variables to store the mils, gallons and ounces
         * 3) Call the VolumeConversion with the appropriate arguments. 
         * 4) Print all of the arguments after the method call 
         * 5) Now change the first argument to 1.25 and repeat step 3 and 4.  
         */
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            double liter = 1;
            double mils, gal, oz;
            VolumeConversion(liter, out mils, out gal, out oz);
            Console.WriteLine("{0} {1} {2} {3}", liter, mils, gal, oz);
            liter = 1.25;
            VolumeConversion(liter, out mils, out gal, out oz);
            Console.WriteLine("{0} {1} {2} {3}", liter, mils, gal, oz);

            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        #endregion

        #region Question 5 - 10 marks
        /* Question 5 (6 marks)
         * 
         * Einstein explained the photoelectric effect using the relationship
         * e=hc/l where h is the Planck constant and c is the speed of light and
         * l is the wavelength of the light involved
         * 
         * Write a method that calculates and returns the energy required to
         * emmit a photon of light. 
         * The specifications is as follows:
         * 
         * Name: 
         *  PhotoElectric
         *  
         * Argument: 
         *  a double representing the wavelength of the photon emited
         *  
         * Returns:
         *  a double indicating the energy change in this process
         *  
         * Action:
         *  Calculates and return the energy required. The  equation will 
         *  be writen on the whiteboard
         *  
         * Displays:
         *  nothing.
         * 
         */
        static double PhotoElectric(double l)
        {
            double e, h = 6.62e-34, c = 299_792_458;
            e = h * c / l;
            return e;
        }


        /* The driver for question 5 (4 mark)
         * 
         * In the DemoQuestion5() method, write the code to call this method two
         * times with arguments 5.55X10^-7 and 4.50X10^-7 respectively and display the 
         * return value after each call
         * 
         * HINT: use e for the format specifier 
         */
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            //code for invoking question 5 goes here
            Console.WriteLine("{0:E}", PhotoElectric(5.55e-7));
            Console.WriteLine("{0:E}", PhotoElectric(4.50e-7));

            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        #endregion

        #region Question 6 - 19 marks
        /* Question 6 (13 marks)
         * 
         * All Canadian are required to pay federal and provincial taxes. This question deals 
         * with federal tax calculation. The question specifications are as follows:
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
            double tax = 0;
            if (income <= 45_282)
            {
                tax = income * 0.15;
            }
            else if (45_282 < income && income <= 90_563)
            {
                tax = 0.15 * 45_282 + 0.205 * (income - 45_282);
            }
            else if (income > 90_563)
            {
                tax = 0.15 * 45_282 + 0.205 * (90_563 - 45_282) + 0.33 * (income - 90_563);
            }
            else
            {
                Console.WriteLine("error");
            }
            return tax;
        }

        /* The driver for question 6 (6 marks)
         * 
         * 1) Declare a double variable and initialized it to 40,000
         * 2) Invoke the CalculateFederalTax method with this variable and print the returned value
         * 3) Change the variable to 80,000 and repeat step 2
         * 4) Change the variable to 120,000 and repeat step 2
         */
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            //code for invoking question 6 goes here
            double income = 40_000, tax;
            tax = CalculateFederalTax(income);
            Console.WriteLine("{0:c}", tax);
            income = 80_000;
            tax = CalculateFederalTax(income);
            Console.WriteLine("{0:c}", tax);
            income = 120_000;
            tax = CalculateFederalTax(income);
            Console.WriteLine("{0:c}", tax);
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
        #endregion
    }
}
