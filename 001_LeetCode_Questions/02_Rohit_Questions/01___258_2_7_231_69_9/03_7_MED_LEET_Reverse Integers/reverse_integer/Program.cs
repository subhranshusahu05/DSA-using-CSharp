/*
 https://leetcode.com/problems/reverse-integer/description/
 7. Reverse Integer
Solved
Medium
Topics
premium lock icon
Companies
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

 

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
 

Constraints:

-231 <= x <= 231 - 1
 
 
 
 
 
 
 
 */




namespace reverse_integer
{
    internal class Program
    {
        static int Reverse_Integers(int nums)
        {

            int rem = 0, ans = 0;
            while (nums != 0)
            {

             rem = nums % 10;
                nums = nums / 10;
              
                if (ans < int.MinValue / 10 || ans > int.MaxValue / 10)
                {
                   
                    return 0;
                }

                ans = ans * 10 + rem;


            }




            return ans;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");

            int nums = Convert.ToInt32(Console.ReadLine());

          

            int result = Reverse_Integers(nums);

            Console.WriteLine(result);



        }
    }
}
