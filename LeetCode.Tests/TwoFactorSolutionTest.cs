using NUnit.Framework;
using System;
namespace LeetCode.Tests
{
	[TestFixture()]
	public class TwoFactorSolutionTest
	{
		[Test()]
		[TestCase(new int[] { 2, 7, 11, 15 }, 9)]
		[TestCase(new int[] { -1, 7, 0, 15, 2, 9, -2 }, 9)]
		public void Solution1_FindTwoNumber_Found(int[] numbers, int target)
		{
			int[] indicies = new int[0];

			var result = TwoSumSolution.Solution1(numbers, target, ref indicies);

			Assert.True(result);
			Assert.True(indicies.Length == 2);
			Assert.True(numbers[indicies[0]] + numbers[indicies[1]] == target);
		}

		[Test()]
		[TestCase(new int[] { 0 }, 0)]
		[TestCase(new int[] { 2, 7, 11, 15 }, 10)]
		[TestCase(new int[] { }, 0)]
		public void Solution1_FindTwoNumber_NotFound(int[] numbers, int target)
		{
			int[] indicies = new int[0];

			var result = TwoSumSolution.Solution1(numbers, target, ref indicies);
			Assert.True(!result);

		}
	}
}
