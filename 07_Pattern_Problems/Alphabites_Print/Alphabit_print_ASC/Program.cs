namespace Alphabit_print_ASC
{
    internal class Program
    {
        /*a b c d e
a b c d e
a b c d e
a b c d e
a b c d e*/
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write((char)(97 + j - 1) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            /*
             a a a a a
            b b b b b
            c c c c c
            d d d d d
            e e e e e
            
            
            
            
            */


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write((char)(97 + i - 1) + " ");
                }
                Console.WriteLine();
            }









        }
    }
}
