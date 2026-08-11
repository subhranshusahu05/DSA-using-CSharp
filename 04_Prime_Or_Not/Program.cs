namespace _04_Prime_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entered you number");

            int a = Convert.ToInt32(Console.ReadLine());

            for (int i =2; i<= /*Math.Sqrt(a)*/  a; i++)    
            {
                if (a % i == 0 ) 
                {
                    Console.WriteLine(" notPrimeNumber");
                    break;
                }

                else
                {
                    Console.WriteLine(" Prime Number");
                }

            }

        }
    }
}
