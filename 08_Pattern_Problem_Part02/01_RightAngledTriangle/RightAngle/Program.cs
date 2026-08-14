namespace RightAngle
{
    internal class Program
    {
        /*
        
        *
        **
        ***
        ****
        *****
      
         */
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for (int j=1;j<=5;j++)
                {
                    if (i>=j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            // second method the dependancy of the is depend on the outer loop
            Console.WriteLine();

            for (int i=1;i<=5;i++)
            {
                for (int j=1; j<=i;j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }






        }
    }
}
