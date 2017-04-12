using System;
namespace LeetCode.Solutions
{
    public static class MyAtoiSolution
    {
        public static int Solution(string str)
        {
            var temp = str;
            if (temp == null)
            {
                throw new NullReferenceException("input can't be null.");
            }
            temp = temp.Trim();
            if (temp.Trim().Length == 0)
            {
                return 0;
                //throw new ArgumentException("input is not a number.");
            }

            var isNegative = temp[0] == '-' ? true : false;
            var i = temp[0] == '+' || temp[0] == '-' ? 1 : 0;
            int result = 0;

            for (; i < temp.Length; i++)
            {
                // convert char value to int value
                var value = temp[i] - '0';

                // not a number exception
                if (value > 9 || value < 0)
                {
                    return result;//throw new ArgumentException("input is not a number.");
                }

                // ignore any leading 0;
                if (value == 0 && result == 0)
                {
                    continue;
                }



                if (!isNegative)
                {
                    if (int.MaxValue / 10.0 > result + value / 10.0)
                    {
                        result = result * 10 + value;
                    }
                    else
                    {
                        return int.MaxValue;
                        //throw new ArgumentException("result exceeds the max int.");
                    }
                }
                else
                {
                    if (int.MinValue / 10.0 < result - value / 10.0)
                    {
                        result = result * 10 - value;
                    }
                    else
                    {
                        return int.MinValue;
                        //throw new ArgumentException("result exceeds the min int.");
                    }
                }

            }

            return result;
        }
    }
}