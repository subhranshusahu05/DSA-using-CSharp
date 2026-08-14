namespace Alphabet_pattern__Horizonal_Same_
{
    internal class Program

    {


        /*
         
         a
        b b
        c c c
        d d d d
        e e e e e
         
         
         
         */


        static void Main(string[] args)
        {
            for (int i=1; i<=5;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write((char)(97+(i-1))+" ");

                }

                Console.WriteLine();
            }
        }
    }
}
