using System;
using System.Collections.Generic;

namespace LeetCode
{
	/// <summary>
	/// https://leetcode.com/problems/two-sum/#/description
	/// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
	/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
	/// </summary>
	public static class TwoSumSolution
	{
		/// <summary>
		/// Time cost O(n), space cost O(n)
		/// </summary>
		/// <returns>The solution1.</returns>
		/// <param name="numbers">Numbers.</param>
		/// <param name="target">Target.</param>
		public static bool Solution1(int[] numbers, int target, ref int[] result)
		{
			if (!(numbers?.Length>2))
			{
				return false;
			}
			SortedList<int, int> dict = new SortedList<int, int>();

			for (int i = 0; i < numbers.Length; i++)
			{
				var number = numbers[i];

				if (dict.ContainsKey(target - number))
				{
					result = new int[2];
					result[0] = dict[target - number];
					result[1] = i;
					return true;
				}
				else
				{
					dict[number] = i;
				}
			}


			return false;
		}
	}
}
