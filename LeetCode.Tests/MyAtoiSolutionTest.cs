using System;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    public class MyAtoiSolutionTest
    {
        [Test]
        [TestCase(null)]
        public void Solution_Null_Error(string str)
        {
            Assert.Throws<NullReferenceException>(() => { LeetCode.Solutions.MyAtoiSolution.Solution((str)); }, "input can't be null.");
        }
        [Test]
        [TestCase("99999999999", ExpectedResult = 2147483647)]
        [TestCase("2147483648", ExpectedResult = 2147483647)]
        public int Solution_Overflow_Max_Positive_Error(string str)
        {
            return LeetCode.Solutions.MyAtoiSolution.Solution((str));
        }

        [Test]
        [TestCase("-99999999999", ExpectedResult = -2147483648)]
        [TestCase("-2147483649", ExpectedResult = -2147483648)]
        public int Solution_Overflow_MinNegative_Error(string str)
        {
            return LeetCode.Solutions.MyAtoiSolution.Solution((str));
        }

        [Test]
        [TestCase("123a", ExpectedResult = 123)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase("1a23", ExpectedResult = 1)]
        public int Solution_Not_A_Number_Error(string str)
        {
            return LeetCode.Solutions.MyAtoiSolution.Solution((str));
        }

        [Test]
        [TestCase("    123  ", ExpectedResult = 123)]
        [TestCase("1234", ExpectedResult = 1234)]
        [TestCase("+1234", ExpectedResult = 1234)]
        [TestCase("2147483647", ExpectedResult = 2147483647)]
        //[TestCase("int.maxvalue", ExpectedResult = "int.maxvalue")]
        public int Solution_Positive_Success(string str)
        {
            return LeetCode.Solutions.MyAtoiSolution.Solution((str));
        }

        [Test]
        [TestCase("-1234", ExpectedResult = -1234)]
        [TestCase("    -1234", ExpectedResult = -1234)]
        [TestCase("-2147483648", ExpectedResult = -2147483648)]
        //[TestCase("int.minvalue", ExpectedResult = "int.minvalue")]
        public int Solution_Negative_Success(string str)
        {
            return LeetCode.Solutions.MyAtoiSolution.Solution((str));

        }

        [Test]
        [TestCase("", ExpectedResult = 0)]
        public int Solution_0_Success(string str)
        {
            return LeetCode.Solutions.MyAtoiSolution.Solution((str));
        }

        [Test]
        [TestCase("0000100", ExpectedResult = 100)]
        [TestCase("-0000100", ExpectedResult = -100)]
        //[TestCase("int.minvalue", ExpectedResult = "int.minvalue")]
        public int Solution_Leading_0_Success(string str)
        {
            return LeetCode.Solutions.MyAtoiSolution.Solution((str));

        }

    }
}

