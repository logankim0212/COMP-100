using System;

namespace Question6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Are you interested in a domestic or foreign" +
                          " cuisine? D/F ");
            string cuisine = Console.ReadLine(); 
            Console.Write("How plates would you like to order? ");
            int plates = Convert.ToInt32(Console.ReadLine());

            double cost;

            switch (cuisine)
            {
                case "D":
                case "d":
                    if (plates <= 100)
                    {
                        cost = 39.95 * plates;
                        Console.WriteLine("The cost of 100 plates will be" +
                                          " {0:c}.", cost); 
                    }
                    else
                    {
                        cost = 34.95 * plates;
                        Console.WriteLine("The cost of 100 plates will be" +
                                          " {0:c}", cost); 
                    }
                    break;
				case "F":
				case "f":
					if (plates <= 100)
					{
						cost = 54.95 * plates;
						Console.WriteLine("The cost of 100 plates will be" +
										  " {0:c}.", cost);
					}
					else
					{
						cost = 44.95 * plates;
						Console.WriteLine("The cost of 100 plates will be" +
										  " {0:c}", cost);
					}
					break;
            }
        }
    }
}
