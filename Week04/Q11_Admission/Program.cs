using System;
/*
 * 1.   Write a console-based program for a college’s admissions office.
 * The user enters a numeric high school grade point average (for example, 3.2)
 * and an admission test score. Display the message “Accept” if the student
 * meets either of the following requirements:
 * A grade point average of 3.0 or higher and an admission test score of at
 * least 60
 * A grade point average of less than 3.0 and an admission test score of at
 * least 80
 * If the student does not meet either of the qualification criteria, display
 * “Reject”.
 */
namespace Q11_Admission
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your admission test score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            if (gpa >= 3.0 && score >= 60 || gpa < 3.0 && score >= 80)
            {
				Console.WriteLine("With the GPA of {0:f1} and admission test" +
								  " score of {1}, you are accpeted."
								  , gpa, score);
			}

            else
            {
                Console.WriteLine("With the GPA of {0:f1} and admission test" +
                                  " score of {1}, you are rejected."
                                  , gpa, score); 
            }
        }
    }
}
