using System;
namespace LeetCode.Solutions
{
    public static class LongestPalindromeSolution
    {
        public static string Solution(string s)
        {
            int begin1 = 0;
            int end1 = 0;
            int begin2 = 0;
            int end2 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // odd length of Palindrome 
                for (int j = i - 1, k = i + 1; j >= 0 && k < s.Length; j--, k++)
                {
                    if (s[j] == s[k])
                    {
                        if ((end1 - begin1) < (k - j))
                        {
                            begin1 = j;
                            end1 = k;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                // even length of palidrome
                for (int j = i, k = i + 1; j >= 0 && k < s.Length; j--, k++)
                {
                    if (s[j] == s[k])
                    {
                        if ((end2 - begin2) < (k - j))
                        {
                            end2 = k;
                            begin2 = j;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if ((end2 - begin2) > (end1 - begin1))
            {
                return s.Substring(begin2, end2 - begin2 + 1);
            }
            else
            {
                return s.Substring(begin1, end1 - begin1 + 1);
            }

        }
    }
}
