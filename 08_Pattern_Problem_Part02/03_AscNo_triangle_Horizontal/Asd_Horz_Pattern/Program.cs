namespace Asd_Horz_Pattern
{
    internal class Program
    {
        /*  1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5*/
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(i+ " ");
                    }


                }
                Console.WriteLine();
            }

            Console.WriteLine();


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                        Console.Write(i + " ");
                    


                }
                Console.WriteLine();
            }



        }
    }
}
