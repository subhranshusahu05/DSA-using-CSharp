using System.Diagnostics;

namespace _05_Prime_or_Not_Happy_ActualCode
{
    internal class Program
    {
        /// <summary>
        /// In this taing a user intput and chcking weather it is prime number  or not?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Printing Message

            Console.WriteLine("Enter Your Number");

            // Taking number from the user

            int a = Convert.ToInt32(Console.ReadLine());

            // Edge case a number less that 2 means -ve number are not prime number

            if (a<2)
            {
                Console.WriteLine("Not a PrimeNumber");
                return;
            }

            // taking a bool is prime is true for initial

            bool isPrime = true;

            // Actual code starts
            // stopwatch

            Stopwatch timer = new Stopwatch();

            // calculate Math.Sqrt(a) for optimization

            double End = Math.Sqrt(a);

            timer.Start();

            for (int i =2; i <= End; i++)
            {
                if(a% i == 0)
                {
                    isPrime = false;
                   break;
                }

            }

            if (isPrime)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");

            }

            timer.Stop();

            Console.WriteLine($"Time taken: {timer.ElapsedMilliseconds} ms");



        }
    }
}
