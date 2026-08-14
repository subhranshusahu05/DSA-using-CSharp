namespace VertivalTrianglrNumber
{
    internal class Program
    {
        /*
         
            1
            1 2
            1 2 3
            1 2 3 4
            1 2 3 4 5
         
         
         
         */
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for (int j=1;j<=5;j++)
                {
                    if (i>=j)
                    {
                        Console.Write(j+" ");
                    }


                }
                    Console.WriteLine();
            }


            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                   
                        Console.Write(j + " ");
                   


                }
                Console.WriteLine();
            }



        }
    }
}
