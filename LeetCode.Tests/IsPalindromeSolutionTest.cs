using System;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class IsPalindromeSolutionTest
    {
        [Test]
        [TestCase(11, ExpectedResult = true)]
        [TestCase(1221, ExpectedResult = true)]
        public bool Solution_Even_Length_True(int x)
        {
            return LeetCode.Solutions.IsPalindromeSolution.Solution((x));
        }

        [Test]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(111, ExpectedResult = true)]
        [TestCase(12321, ExpectedResult = true)]
        public bool Solution_Odd_Length_True(int x)
        {
            return LeetCode.Solutions.IsPalindromeSolution.Solution((x));
        }

        [Test]
        [TestCase(1122, ExpectedResult = false)]
        [TestCase(-1122, ExpectedResult = false)]
        [TestCase(123, ExpectedResult = false)]
        [TestCase(-123, ExpectedResult = false)]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(1000021, ExpectedResult = false)]
        public bool Solution_False(int x)
        {
            return LeetCode.Solutions.IsPalindromeSolution.Solution((x));
        }
    }
}
