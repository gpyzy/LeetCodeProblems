using System;
using System.Collections.Generic;

namespace LeetCode.Solutions
{
	/// <summary>
	/// https://leetcode.com/problems/longest-substring-without-repeating-characters/#/description
	/*
		Given a string, find the length of the longest substring without repeating characters.
		Examples:
		Given "abcabcbb", the answer is "abc", which the length is 3.
		Given "bbbbb", the answer is "b", with the length of 1.
		Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

		the basic idea is, keep a hashmap which stores the characters in string as keys and their positions as values, 
		and keep two pointers which define the max substring. move the right pointer to scan through the string , 
		and meanwhile update the hashmap. If the character is already in the hashmap, then move the left pointer to 
		the right of the same character last found. Note that the two pointers can only move forward.
	*/
	/// </summary>
	public static class LengthOfLongestSubstringSolution
	{

		public static int Solution(String s)
		{
			var max = 0;
			var dict = new Dictionary<char, int>();

			for (int i = 0, j = 0; i < s.Length; i++)
			{
				if (dict.ContainsKey(s[i]))
				{
					j = Math.Max(j, dict[s[i]] + 1);
				}

				dict[s[i]] = i;

				max = Math.Max(max, i - j + 1);
			}

			return max;
		}
	}
}
