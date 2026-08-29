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

/*
 
 



namespace _258._Add_Digits
{
    internal class Program
    {
        

        static int AddDigits(int num)
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


        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = AddDigits(num);

            Console.WriteLine("Single digit result: " + result);
        }



    }
}





 
 
 
 
 */




/*
//namespace _258._Add_Digits
//{
//    internal class Program
//    {
//        /*
//            NON-STATIC METHOD

//            AddDigits() is a non-static method because we have
//            NOT used the 'static' keyword.

//            Therefore, we need to create an object of the
//            Program class before calling AddDigits().
//        */

//public int AddDigits(int num)
//{
//    while (num > 9)
//    {
//        int rem = 0;
//        int ans = 0;

//        while (num != 0)
//        {
//            rem = num % 10;
//            num = num / 10;
//            ans = ans + rem;
//        }

//        num = ans;
//    }

//    return num;
//}


//static void Main(string[] args)
//{
//    Console.Write("Enter a number: ");
//    int num = Convert.ToInt32(Console.ReadLine());


//    /*
//        OBJECT CREATION

//        AddDigits() is non-static.

//        Main() is static.

//        A static method cannot directly call a
//        non-static method.

//        Therefore, we create an object of Program class.

//        Syntax:

//            ClassName objectName = new ClassName();
//    */

//    Program obj = new Program();


//    /*
//        CALLING NON-STATIC METHOD

//        We use the object 'obj' to call AddDigits().

//        obj → object of Program class
//        AddDigits() → non-static method
//    */

//    int result = obj.AddDigits(num);


//    // Display the result
//    Console.WriteLine("Single digit result: " + result);
//}
//    }
//}







//*/
