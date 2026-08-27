namespace Binary_To_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int ans = 0;
            int rem = 0;
            int mul = 1;

            while (num > 0)
            {
                rem = num % 10;
                // Console.WriteLine("The reminber is"+rem);

                ans = ans + rem * mul;

                //  Console.WriteLine("The Answer is"+ans);
                mul = mul * 2;

                //  Console.WriteLine("The mul is"+mul);
                num = num / 10;

                //  Console.WriteLine("The number is"+num);

            }
            Console.WriteLine("The actual answer is " + ans);
        }
    }
}
