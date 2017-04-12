using System;
namespace LeetCode.Solutions
{
    public static class IsPalindromeSolution
    {
        /// <summary>
        /// https://leetcode.com/problems/palindrome-number/#/description
        /// Determine whether an integer is a palindrome. Do this without extra space.
        /// </summary>
        /// <returns>The solution.</returns>
        /// <param name="x">The x coordinate.</param>
        public static bool Solution(int x)
        {
            if (x < 0 || (x > 0 && x % 10 == 0)) return false;
            int temp = 0;

            while (temp < x)
            {
                temp = temp * 10 + x % 10;
                x = x / 10;
            }


            if (temp == x || (temp - x * 10) / 10 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
