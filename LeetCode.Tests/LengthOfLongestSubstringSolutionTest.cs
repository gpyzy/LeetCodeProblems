using System;
using NUnit.Framework;
using LeetCode.Solutions;

namespace LeetCode.Tests
{
	[TestFixture]
	public class LengthOfLongestSubstringSolutionTest
	{
		[Test]
		[TestCase("abacdcbaade", Result = 4)]
		[TestCase("abcabcbb", Result = 3)]
		[TestCase("bbbbb", Result = 1)]
		[TestCase("pwwkew", Result = 3)]
		public int Solution_Found_Success(string input)
		{
			return LengthOfLongestSubstringSolution.Solution(input);
		}
	}
}
