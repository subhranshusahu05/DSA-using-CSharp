namespace _07_Questions
{
    /*
     
    *
   ***
  *****
 *******
*********
     
     
     
     
     
     */
    internal class Program
    {
        /*
         
         
    *
   ***
  *****
 *******
*********
         
         
         
         
         
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int p = 1; p <= 5-i; p++)
                {
                    Console.Write(" ");
                }

                for (int p = 1; p <= i-1 ; p++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }



                Console.WriteLine();
            }
        }
    }
}
