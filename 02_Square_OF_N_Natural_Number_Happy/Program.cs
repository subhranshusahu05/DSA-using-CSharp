namespace _02_Square_OF_N_Natural_Number_Happy
{
    internal class Program
    {
        /// <summary>
        /// sun of square of N natural Numbers 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you number");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i=1; i <= a; i++ )
            {

                // sum += i * i;
                sum = sum + i * i;

            }

            Console.WriteLine("the square of the number is " + sum);



        }
    }
}
