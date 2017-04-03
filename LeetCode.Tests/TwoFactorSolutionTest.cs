using NUnit.Framework;
using System;
using System.Diagnostics;
namespace LeetCode.Tests
{

	[TestFixture()]
	public class TwoFactorSolutionTest
	{
		const int PERFORMANCE_TEST_ITERATION = 1000000;


		[Test()]
		[TestCase(new int[] { 2, 7, 11, 15 }, 9)]
		[TestCase(new int[] { -1, 7, 0, 15, 2, 9, -2 }, 9)]
		public void Solution1_FindTwoNumber_Found(int[] numbers, int target)
		{
			int[] indicies = new int[0];
			//var sw = new Stopwatch();
			//sw.LogResult(() =>
			//{
			var result = TwoSumSolution.Solution1(numbers, target, ref indicies);
			Assert.True(result);
			Assert.True(indicies.Length == 2);
			Assert.True(numbers[indicies[0]] + numbers[indicies[1]] == target);
			//}, PERFORMANCE_TEST_ITERATION, "Solution1_FindTwoNumber_Found");

		}

		[Test()]
		[TestCase(new int[] { 0 }, 0)]
		[TestCase(new int[] { 2, 7, 11, 15 }, 10)]
		[TestCase(new int[] { }, 0)]
		public void Solution1_FindTwoNumber_NotFound(int[] numbers, int target)
		{
			int[] indicies = new int[0];
			//var sw = new Stopwatch();

			//sw.LogResult(() =>
			//{
			var result = TwoSumSolution.Solution1(numbers, target, ref indicies);
			Assert.True(!result);
			//}, PERFORMANCE_TEST_ITERATION, "Solution1_FindTwoNumber_NotFound");

		}

		[Test()]
		[TestCase(new int[] { 2, 7, 11, 15 }, 9)]
		[TestCase(new int[] { -1, 7, 0, 15, 2, 9, -2 }, 9)]
		public void Solution2_FindTwoNumber_Found(int[] numbers, int target)
		{
			int[] indicies = new int[0];

			//var sw = new Stopwatch();
			//sw.LogResult(() =>
			//{
			var result = TwoSumSolution.Solution2(numbers, target, ref indicies);
			Assert.True(result);
			Assert.True(indicies.Length == 2);
			Assert.True(numbers[indicies[0]] + numbers[indicies[1]] == target);
			//}, PERFORMANCE_TEST_ITERATION, "Solution2_FindTwoNumber_Found");
		}

		[Test()]
		[TestCase(new int[] { 0 }, 0)]
		[TestCase(new int[] { 2, 7, 11, 15 }, 10)]
		[TestCase(new int[] { }, 0)]
		public void Solution2_FindTwoNumber_NotFound(int[] numbers, int target)
		{
			int[] indicies = new int[0];
			//var sw = new Stopwatch();
			//sw.LogResult(() =>
			//{
			var result = TwoSumSolution.Solution1(numbers, target, ref indicies);
			Assert.True(!result);
			//}, PERFORMANCE_TEST_ITERATION, "Solution2_FindTwoNumber_NotFound");
		}
	}
}
