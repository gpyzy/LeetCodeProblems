using System;
using NUnit.Framework;
using LeetCode.Solutions;

namespace LeetCode.Tests
{
    [TestFixture]
    public class LengthOfLongestSubstringSolutionTest
    {
        [Test]
        [TestCase("abacdcbaade", ExpectedResult = 4)]
        [TestCase("abcabcbb", ExpectedResult = 3)]
        [TestCase("bbbbb", ExpectedResult = 1)]
        [TestCase("pwwkew", ExpectedResult = 3)]
        public int Solution_Found_Success(string input)
        {
            return LengthOfLongestSubstringSolution.Solution(input);
        }
    }
}
