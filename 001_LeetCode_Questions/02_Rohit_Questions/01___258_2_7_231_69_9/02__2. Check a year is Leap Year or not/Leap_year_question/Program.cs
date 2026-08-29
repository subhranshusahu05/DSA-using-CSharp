namespace Leap_year_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");

            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 ==0)
            {
                Console.WriteLine(year + " is a leap year.");

            }
            else if (year % 4 ==0 && year % 100 !=0)
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
