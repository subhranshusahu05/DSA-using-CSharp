namespace Number_Pattern_HorizontalSame
{
    internal class Program
    {
        /// <summary>
        /// 1 1 1 1 1
            //2 2 2 2 2 
            //3 3 3 3 3 
            //4 4 4 4 4
            //5 5 5 5 5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();

            }

        }
    }
}
