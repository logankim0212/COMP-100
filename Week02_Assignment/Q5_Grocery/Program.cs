using System;

namespace Q5_Grocery
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//Input
			int price;
			int weight;
			int bagprice;
            int bagcapacity;
            //Processing
            int currentprice;
            int numberofbag;
            int totalbagprice;
			//Output
			int cost;
			//Algorithm
            Console.Write("Enter the price of the produce (cents/lb): ");
			price = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the weight of the produce (lb): ");
			weight = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the price of the plastic bag (cents): ");
            bagprice = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the capacity of bag (lb): ");
            bagcapacity = Convert.ToInt32(Console.ReadLine());

            currentprice = price * weight;
            numberofbag = (weight - 1) / bagcapacity + 1;
            totalbagprice = numberofbag * bagprice;

            cost = currentprice + totalbagprice;
			
            Console.WriteLine(cost);
        }
    }
}
