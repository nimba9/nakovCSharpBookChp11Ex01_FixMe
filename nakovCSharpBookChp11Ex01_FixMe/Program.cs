using System;

/* 
 * The following program contains an error made 
 * during the process of solving.
 * It serves as a remainder and memory training.
 */

namespace nakovCSharpBookChp11Ex01_FixMe
{
    class LeapYearChecking
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number representing a year: ");
            string year = Console.ReadLine();

            CheckLeapYear(year);
        }

        public static void CheckLeapYear(string year)
        {
            int num = 0;

            bool validInput = int.TryParse(year, out num);

            Console.WriteLine("Is the year {0} that you entered a leap year? {1}", DateTime.IsLeapYear(num));
        }
    }
}
