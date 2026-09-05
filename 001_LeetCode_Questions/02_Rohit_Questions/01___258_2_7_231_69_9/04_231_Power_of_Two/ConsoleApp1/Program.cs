/*
https://leetcode.com/problems/power-of-two/description/
 231. Power of Two
Solved
Easy
Topics
premium lock icon
Companies
Given an integer n, return true if it is a power of two. Otherwise, return false.

An integer n is a power of two, if there exists an integer x such that n == 2x.

 

Example 1:

Input: n = 1
Output: true
Explanation: 20 = 1
Example 2:

Input: n = 16
Output: true
Explanation: 24 = 16
Example 3:

Input: n = 3
Output: false
 

Constraints:

-231 <= n <= 231 - 1
 

Follow up: Could you solve it without loops/recursion?
 
 
 
 
 */



namespace ConsoleApp1
{
    internal class Program
    {
        static bool PowerOfTwo(int n)
        {
            if (n <= 0) { return false; }
            if (n == 1) { return true; }
            while (n != 0)
            {
                if (n == 1) { return true; }


                if (n % 2 == 1) { return false; }

                n = n / 2;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");

            int n = Convert.ToInt32(Console.ReadLine());

            bool result = PowerOfTwo(n);

            if (result )
            {
                Console.WriteLine("The number is a power of two");
            }
            else
            {
                Console.WriteLine("The number is not a power of two");
            }


        }
    }
}
