namespace NumberPaternVertically
{
    internal class Program
    {
        /// <summary>
        /// 1 2 3 4 5
        //1 2 3 4 5
        //1 2 3 4 5
        //1 2 3 4 5
        //1 2 3 4 5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();



            }
        }
    }
}
