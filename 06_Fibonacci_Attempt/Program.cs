namespace _06_Fibonacci_Attempt
{
    internal class Program
    {
        /// <summary>
        /// 0 1 1 2 3 5 8 13 21 34 55 89......
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");

            int number = Convert.ToInt32(Console.ReadLine());

            int current = 0;    

            int prev = 1;

            int last = 0;

            for (int i = 1; i<=number; i++)
            {
                current = prev + last;

                last = prev;
                prev = current;

                Console.WriteLine(current);


            }




        }
    }
}
