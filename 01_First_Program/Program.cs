using System.Diagnostics;

namespace _01_First_Program
{
    internal class Program
    {
        /// <summary>
        /// Sum of natural numbers from A to B using for loop and measure the time taken to execute the code.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            

            Stopwatch timer = new Stopwatch();

            

            Console.WriteLine("Enter your First/ starting number");
           int  A  = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter your Ending number");
            int B = int.Parse(Console.ReadLine()!);
            int sum = 0;

            timer.Start();

            for (int i = A; i <= B; i++) 
            {
             
                sum = sum + i;  

            }

            timer.Stop();
            Console.WriteLine("The sum of number from " + A + " to " + B + " is " + sum);
            Console.WriteLine("Time taken: " + timer.ElapsedMilliseconds + " ms");
        }
    }
}
