using System;
/*
 * To the Lawn application you created in the above question, add a prompt
 * that asks the user whether the customer wants to pay (1) once, (2) twice,
 * or (3) 20 times per season. If the user enters 1 for once, the fee for
 * the season is simply the seasonal total. If the customer requests two
 * payments, each payment is half the seasonal fee plus a $5 service charge.
 * If the user requests 20 separate payments, add a $3 service charge per week.
 * Display the number of payments the customer must make, each payment amount,
 * and the total for the season.
 */
namespace Q13_LawnPayment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //lawn cost starts here
            Console.Write("Enter the length of a lawn (ft): ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of a lawn (ft): ");
            int width = Convert.ToInt32(Console.ReadLine());
            int area = length * width;
            if (area < 400)
            {
                int weeklyfee = area * 25;
                int seasonfee = weeklyfee * 20;
                Console.WriteLine("The weekly mowing fee is {0:c}, and the" +
                                  " total fee for the 20-week season is" +
                                  " {1:c}.", weeklyfee, seasonfee);
            }
            else if (area > 400 && area < 600)
            {
                int weeklyfee = area * 35;
                int seasonfee = weeklyfee * 20;
                Console.WriteLine("The weekly mowing fee is {0:c}, and the" +
                                  " total fee for the 20-week season is" +
                                  " {1:c}.", weeklyfee, seasonfee);
            }
            else if (area > 600)
            {
                int weeklyfee = area * 50;
                int seasonfee = weeklyfee * 20;
                Console.WriteLine("The weekly mowing fee is {0:c}, and the" +
                                  " total fee for the 20-week season is" +
                                  " {1:c}.", weeklyfee, seasonfee);
            }
            //Lawn payment starts here
            Console.WriteLine();
            Console.WriteLine("Enter the way that you want to pay follow the" +
                          " selection below.");
            Console.WriteLine("Type 1 if you want to pay once per season.");
            Console.WriteLine("Type 2 if you want to pay twice per season.");
            Console.WriteLine("Type 3 if you want to pay 20 times per season.");
            string payment = Console.ReadLine();
            switch (payment)
            {
                case "1":
                    if (area < 400)
                    {
                        int weeklyfee = area * 25;
                        int seasonfee = weeklyfee * 20;
						Console.WriteLine("You need to make only one" +
										  " payments, {0:c}. (There is" +
										  " no service charge.)"
										  , seasonfee);
						Console.WriteLine("The total amount at the end is" +
										  " also {0:c}."
										  , seasonfee);

                    }
                    else if (area > 400 && area < 600)
                    {
                        int weeklyfee = area * 35;
                        int seasonfee = weeklyfee * 20;
						Console.WriteLine("You need to make only one" +
										  " payments, {0:c}. (There is" +
										  " no service charge.)"
										  , seasonfee);
						Console.WriteLine("The total amount at the end is" +
										  " also {0:c}."
										  , seasonfee);

                    }
                    else if (area > 600)
                    {
                        int weeklyfee = area * 50;
                        int seasonfee = weeklyfee * 20;
						Console.WriteLine("You need to make only one" +
                                          " payments, {0:c}. (There is" +
                                          " no service charge.)"
                                          , seasonfee);
						Console.WriteLine("The total amount at the end is" +
										  " also {0:c}."
										  , seasonfee);

                    }

                    break;
                case "2":
                    if (area < 400)
                    {
                        int weeklyfee = area * 25;
                        int seasonfee = weeklyfee * 20;
                        int halfseason = seasonfee / 2 + 5;
						int total = halfseason * 20;
						Console.WriteLine("You need to make 2 separate" +
										  " payments, {0:c} each. (There is" +
										  " $5 service charge for each" +
										  " payment.)"
										  , halfseason);
						Console.WriteLine("The total amount at the end is" +
										  " {0:c}."
										  , total);
                    }
                    else if (area > 400 && area < 600)
                    {
                        int weeklyfee = area * 35;
                        int seasonfee = weeklyfee * 20;
                        int halfseason = seasonfee / 2 + 5;
						int total = halfseason * 20;
						Console.WriteLine("You need to make 2 separate" +
										  " payments, {0:c} each. (There is" +
										  " $5 service charge for each" +
										  " payment.)"
										  , halfseason);
						Console.WriteLine("The total amount at the end is" +
										  " {0:c}."
										  , total);
                    }
                    else if (area > 600)
                    {
                        int weeklyfee = area * 50;
                        int seasonfee = weeklyfee * 20;
                        int halfseason = seasonfee / 2 + 5;
						int total = halfseason * 20;
						Console.WriteLine("You need to make 2 separate" +
										  " payments, {0:c} each. (There is" +
										  " $5 service charge for each" +
										  " payment.)"
										  , halfseason);
						Console.WriteLine("The total amount at the end is" +
										  " {0:c}."
										  , total);
                    }

                    break;
                case "3":
                    if (area < 400)
                    {
                        int weeklyfee = area * 25;
                        int seasonfee = weeklyfee * 20;
                        int eachseason = seasonfee / 20 + 3;
                        int total = eachseason * 20;
                        Console.WriteLine("You need to make 20 separate" +
                                          " payments, {0:c} each. (There is" +
                                          " $3 service charge for each" +
                                          " payment.)"
                                          , eachseason);
                        Console.WriteLine("The total amount at the end is" +
                                          " {0:c}."
										  , total);
                    }
                    else if (area > 400 && area < 600)
                    {
                        int weeklyfee = area * 35;
                        int seasonfee = weeklyfee * 20;
                        int eachseason = seasonfee / 20 + 3;
						int total = eachseason * 20;
						Console.WriteLine("You need to make 20 separate" +
										  " payments, {0:c} each. (There is" +
										  " $3 service charge for each" +
										  " payment.)"
										  , eachseason);
						Console.WriteLine("The total amount at the end" +
                                          " is {0:c}."
										  , total);
                    }
                    else if (area > 600)
                    {
                        int weeklyfee = area * 50;
                        int seasonfee = weeklyfee * 20;
                        int eachseason = seasonfee / 20 + 3;
						int total = eachseason * 20;
						Console.WriteLine("You need to make 20 separate" +
										  " payments, {0:c} each. (There is" +
										  " $3 service charge for each" +
										  " payment.)"
										  , eachseason);
						Console.WriteLine("The total amount at the end" +
                                          " is {0:c}."
										  , total);
                    }
                    break;
            }
        }
    }
}
