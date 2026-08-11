namespace _02_Sum_OF_N_NaturalNumbers
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i =1; i<=a; i++)
            {
                sum += i;
            }


            Console.WriteLine("The sum of first " + a + " natural numbers is: " + sum);
        }
    }
}
