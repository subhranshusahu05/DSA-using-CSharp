namespace Test_My
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string ? binary = Console.ReadLine();
            int totalSum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                int digit = binary[i] - '0';
                int power = binary.Length - 1 - i;
                int product = digit * (int)Math.Pow(2, power);

                Console.WriteLine($"{digit} × 2^{power} = {product}");
                totalSum += product;
            }

            Console.WriteLine($"Total: {totalSum}");

        }
    }
}
