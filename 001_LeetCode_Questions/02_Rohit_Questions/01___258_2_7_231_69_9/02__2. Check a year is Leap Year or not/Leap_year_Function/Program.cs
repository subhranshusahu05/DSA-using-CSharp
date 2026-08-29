using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Leap_year_Function
{
    internal class Program
    {
        // function make
        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) { return true; }
            else if (year % 4 == 0 && year % 100! == 0) { return true; }
            else
            {

                return false;
            }
        }



        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");

            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeap = IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");



            }



        }
    }
}
