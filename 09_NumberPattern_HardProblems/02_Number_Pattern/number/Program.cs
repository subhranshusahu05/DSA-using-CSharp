namespace number
{
    internal class Program
    {
        /*
         
                1
               22
              333
             4444
            55555
         
         
         
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                //blank print
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");

                }

                //Print star

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);

                }

                Console.WriteLine();


            }
        }
    }
}
