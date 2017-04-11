using System;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class LongestPalindromeSolutionTest
    {

        [Test]
        [TestCase("babad", ExpectedResult = "bab")]
        [TestCase("123454321", ExpectedResult = "123454321")]
        [TestCase("12345676543a1", ExpectedResult = "345676543")]
        [TestCase("aaa", ExpectedResult = "aaa")]
        [TestCase("cabdfffdc", ExpectedResult = "dfffd")]
        [TestCase("11211  abacabadfffd", ExpectedResult = "abacaba")]
        [TestCase("abdfffdc", ExpectedResult = "dfffd")]
        public string Solution_OddLength_Success(string s)
        {
            return LeetCode.Solutions.LongestPalindromeSolution.Solution(s);
        }

        [Test]
        [TestCase("abba", ExpectedResult = "abba")]
        [TestCase("cabdffdbc", ExpectedResult = "bdffdb")]
        [TestCase("11", ExpectedResult = "11")]
        public string Solution_EvenLength_Success(string s)
        {
            return LeetCode.Solutions.LongestPalindromeSolution.Solution(s);
        }
    }
}
