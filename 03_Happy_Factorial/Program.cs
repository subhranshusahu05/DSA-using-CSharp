namespace _03_Happy_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");

            int a = Convert.ToInt32(Console.ReadLine());

            int facto = 1;

            //for ( int i = a; i >=1; i--) 
            //{

            //    facto =  facto * i;
            
            
            //}


            for ( int i = 1; i<=a; i++)
            {
                facto = facto * i;

            }

            Console.WriteLine("the factorial is "+ facto);

        }
    }
}
