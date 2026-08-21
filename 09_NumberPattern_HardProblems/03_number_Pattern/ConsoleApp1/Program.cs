namespace ConsoleApp1
{/*
  

    1
   12
  123
 1234
12345
  
  
  
  
  */
    internal class Program
    {
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
                    Console.Write(j);

                }

                Console.WriteLine();


            }
        }
    }
}
