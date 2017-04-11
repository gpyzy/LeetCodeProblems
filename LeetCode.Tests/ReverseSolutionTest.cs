using System;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class ReverseSolutionTest
    {

        [Test]
        [TestCase(1234, ExpectedResult = 4321)]
        public int Solution_Positive_Success(int x)
        {
            return LeetCode.Solutions.ReverseSolution.Solution(x);
        }


        [Test]
        [TestCase(-1234, ExpectedResult = -4321)]
        public int Solution_Negative_Success(int x)
        {
            return LeetCode.Solutions.ReverseSolution.Solution(x);
        }

        [Test]
        //[TestCase(1234567899, ExpectedResult = 0)]
        [TestCase(-1234567899, ExpectedResult = 0)]
        public int Solution_Overflow_Return_0_Success(int x)
        {
            return LeetCode.Solutions.ReverseSolution.Solution(x);
        }

        [Test]
        [TestCase(100, ExpectedResult = 1)]
        public int Solution_EndWith0_Success(int x)
        {
            return LeetCode.Solutions.ReverseSolution.Solution(x);
        }
    }
}
