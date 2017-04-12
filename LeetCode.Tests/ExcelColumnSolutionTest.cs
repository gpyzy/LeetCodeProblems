using System;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class ExcelColumnSolutionTest
    {
        [Test]
        [TestCase(1, ExpectedResult = "A")]
        [TestCase(52, ExpectedResult = "AZ")]
        [TestCase(53, ExpectedResult = "BA")]
        [TestCase(53, ExpectedResult = "BB")]
        public string Solution_Success(int x)
        {
            return LeetCode.Solutions.ExcelColumnSolution.Solution(x);
        }
    }
}
