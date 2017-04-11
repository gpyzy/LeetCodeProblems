using System;
namespace LeetCode.Solutions
{
    public static class ReverseSolution
    {
        /// <summary>
        /// https://leetcode.com/problems/reverse-integer/#/description
        /// Reverse digits of an integer.
        /// Example1: x = 123, return 321
        /// Example2: x = -123, return -321
        /// </summary>
        /// <returns>The solution.</returns>
        /// <param name="x">The x coordinate.</param>
        public static int Solution(int x)
        {
            int result = 0;
            var temp = x;

            while (temp != 0)
            {
                var tail = temp % 10;

                if (x > 0)
                {
                    if (int.MaxValue / 10 + tail < result)
                    {
                        return 0;
                    }
                }
                else
                {
                    if (int.MinValue / 10 + tail > result)
                    {
                        return 0;
                    }

                }

                result = result * 10 + tail;

                temp = temp / 10;
            }

            return result;
        }
    }
}
