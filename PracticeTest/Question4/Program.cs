using System;

namespace Question4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the temperature of the room: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (temperature < 19.5)
            {
                Console.WriteLine("Too cold");
            }
            else if (temperature > 22.5)
            {
                Console.WriteLine("Too warm");
            }
            else
            {
                Console.WriteLine("Just right");
            }
        }
    }
}
