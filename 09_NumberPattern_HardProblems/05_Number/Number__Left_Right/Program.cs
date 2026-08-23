namespace Number__Left_Right
{
    internal class Program
    {
        /*
         

            1
           21
          321
         4321
        54321
         
         
         
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i-j+1);

                }

                Console.WriteLine();

            }
        }
    }
}
