/*
 https://leetcode.com/problems/add-digits/
 
258. Add Digits
Solved
Easy

Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

Example 1:

Input: num = 38
Output: 2
Explanation: The process is
38 --> 3 + 8 --> 11
11 --> 1 + 1 --> 2 
Since 2 has only one digit, return it.
Example 2:

Input: num = 0
Output: 0
 

Constraints:

0 <= num <= 231 - 1
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 
 
 
 */

namespace _258._Add_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

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

            Console.WriteLine("Single digit result: " + num);
        }

        
    }
}

