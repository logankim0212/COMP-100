using System;
/*
 * Harmonised tax exists in Ontario, New Brunswick, New Foundland, Nova Scotia,
 * and British Columbia. Use a suitable enum declaration and a switch statement
 * to prompt the user for a province and display a message HST exist or HST
 * does not exist. enum {ON, QC, NS, NB, MB, BC, PE, SK, AB, NL, YT, NT, NV}
 */
namespace Q7_Tax
{
    class MainClass
    {
        public enum province { ON, QC, NS, NB, MB, BC, PE, SK, AB, NL, YT, NT, NV }
        public static void Main(string[] args)
        {
            Console.Write("Enter the province in Canada (Two letters with" +
                          " all capitals letters): ");
            province province = (province)Enum.Parse(typeof(province), Console.ReadLine()); 

            switch (province)
            {
                case province.ON:
				case province.NL:
				case province.NS:
				case province.BC:
                    Console.WriteLine("HST exist in {0}.", province);
                    break;
                default:
					Console.WriteLine("HST does not exist in {0}.", province);
					break;
			}
        }
    }
}
