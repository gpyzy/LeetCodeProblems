using System;
using LeetCode.DataStructures;
namespace LeetCode.Solutions
{
	public static class AddTwoNumbersSolution
	{
		/// <summary>
		/// https://leetcode.com/problems/add-two-numbers/#/description
		/// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
		/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
		/// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
		/// Output: 7 -> 0 -> 8
		/// </summary>
		/// <returns>The solution.</returns>
		/// <param name="l1">L1.</param>
		/// <param name="l2">L2.</param>
		public static ListNode<int> Solution1(ListNode<int> l1, ListNode<int> l2)
		{
			var node = new ListNode<int> { Value = int.MinValue };
			var first = node;
			var tl1 = l1;
			var tl2 = l2;

			var carry = 0;

			while (tl1 != null || tl2 != null || carry != 0)
			{
				Solution1Calculate(tl1, tl2, node, ref carry);
				if (tl1 != null) tl1 = tl1.Next;
				if (tl2 != null) tl2 = tl2.Next;
				node = node.Next;
			}

			return first.Next;
		}

		private static void Solution1Calculate(ListNode<int> l1, ListNode<int> l2, ListNode<int> result, ref int carry)
		{
			var val1 = l1 == null ? 0 : l1.Value;
			var val2 = l2 == null ? 0 : l2.Value;

			if (val1 < 0 || val2 < 0)
			{
				throw new ArgumentException("the value must be greater than 0");
			}

			var value = val1 + val2 + carry;

			var unitsDigit = value % 10;
			var tensDigit = (value - unitsDigit) / 10;

			carry = tensDigit;


			result.Next = new ListNode<int> { Value = unitsDigit };

		}
	}
}
