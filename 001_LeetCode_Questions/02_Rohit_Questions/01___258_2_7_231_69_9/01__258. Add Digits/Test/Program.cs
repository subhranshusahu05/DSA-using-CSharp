namespace Test
{
    public class Program1 
    {    
       public int AddDigits(int num)
       {
            while (num > 9)
            {
                int rem = 0;
                int ans = 0;

                while (num != 0)
                {
                    rem = num % 10;
                    num = num / 10;
                    ans = ans + rem;
                }

                num = ans;
            }

            return num;
       }
    }
    public class program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Program1 obj = new Program1();
            int result = obj.AddDigits(num);
            Console.WriteLine("Single digit result: " + result);
        }
    }
}
