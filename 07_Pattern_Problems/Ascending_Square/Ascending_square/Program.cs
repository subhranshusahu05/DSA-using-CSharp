namespace Ascending_square
{
    internal class Program
    {

          /*1 4 9 16 25
            1 4 9 16 25
            1 4 9 16 25
            1 4 9 16 25
            1 4 9 16 25*/
        static void Main(string[] args)
        {
            for (int i=1; i<=5;i++)
            {
                for (int j=1; j<=5; j++)
                {
                                        Console.Write(j*j + " ");


                }
                Console.WriteLine();
            }
        }
    }
}
