namespace DescendingNumberpattern
{
    internal class Program
    {

        /// <summary>
        /// 5 4 3 2 1
        //5 4 3 2 1
        //5 4 3 2 1
        //5 4 3 2 1
        //5 4 3 2 1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= 1; j--)
                {

                    Console.Write(j + " ");

                }

                Console.WriteLine();
            }

            Console.WriteLine();


                       /* 5 5 5 5 5
                        4 4 4 4 4
                        3 3 3 3 3
                        2 2 2 2 2
                        1 1 1 1 1*/

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= 1; j--)
                {

                    Console.Write(i + " ");

                }

                Console.WriteLine();
            }



        }
    }
}
