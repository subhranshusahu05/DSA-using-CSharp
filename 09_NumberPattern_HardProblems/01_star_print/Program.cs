using System.Security.Cryptography;

namespace _01_star_print
{
    /*
    

    *
   **
  ***
 ****
*****
    
    
    
    */
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i =1; i<=5; i++)
            {
                //blank print
                for (int j=1;j<=5-i;j++)
                {
                    Console.Write(" ");

                }

                //Print star

                for (int j=1;j<=i;j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();


            }


        }
    }
}
