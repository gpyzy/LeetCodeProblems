using System;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class LongestPalindromeSolutionTest
    {

        [Test]
        [TestCase("babad", Result = "bab")]
        [TestCase("123454321", Result = "123454321")]
        [TestCase("12345676543a1", Result = "345676543")]
        [TestCase("aaa", Result = "aaa")]
        [TestCase("cabdfffdc", Result = "dfffd")]
        [TestCase("11211  abacabadfffd", Result = "abacaba")]
        [TestCase("abdfffdc", Result = "dfffd")]
        public string Solution_OddLength_Success(string s)
        {
            return LeetCode.Solutions.LongestPalindromeSolution.Solution(s);
        }

        [Test]
        [TestCase("abba", Result = "abba")]
        [TestCase("cabdffdbc", Result = "bdffdb")]
        [TestCase("11", Result = "11")]
        public string Solution_EvenLength_Success(string s)
        {
            return LeetCode.Solutions.LongestPalindromeSolution.Solution(s);
        }
    }
}
