using System;
using System.Collections.Generic;
using LeetCode.DataStructures;
using NUnit.Framework;

namespace LeetCode.Tests
{
	[TestFixture]
	public class AddTwoNumbersSolutionTest
	{
		public AddTwoNumbersSolutionTest()
		{
		}

		[Test]
		[TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, Result = new int[] { 7, 0, 8 })]
		[TestCase(new int[] { 2, 4, 3, 9 }, new int[] { 5, 6, 4, 1 }, Result = new int[] { 7, 0, 8, 0, 1 })]
		[TestCase(new int[] { 1, 6, 0, 3, 3, 6, 7, 2, 0, 1 }, new int[] { 6, 3, 0, 8, 9, 6, 6, 9, 6, 1 }, ExpectedResult = new int[] { 7, 9, 0, 1, 3, 3, 4, 2, 7, 2 })]//2724331097
		public int[] Solution1_EqualLengthInput_Success(int[] a1, int[] a2)
		{
			var node1 = Array2ListNode(a1);
			var node2 = Array2ListNode(a2);

			var result = LeetCode.AddTwoNumbersSolution.Solution1(node1, node2);

			return ListNode2Array(result);
		}

		[Test]
		[TestCase(new int[] { 1, 2 }, new int[] { 3 }, Result = new int[] { 4, 2 })]
		[TestCase(new int[] { 1, 2, 3 }, new int[] { 0, 3 }, Result = new int[] { 1, 5, 3 })]
		public int[] Solution1_NotEqualLengthInput_Success(int[] a1, int[] a2)
		{
			var node1 = Array2ListNode(a1);
			var node2 = Array2ListNode(a2);

			var result = LeetCode.AddTwoNumbersSolution.Solution1(node1, node2);

			return ListNode2Array(result);
		}

		[Test]
		[TestCase(new int[] { -1 }, new int[] { 3 })]
		[ExpectedException(typeof(ArgumentException))]
		//[TestCase(new int[] { 1, 2, 3 }, new int[] { 0, 3 }, Result = new int[] { 1, 5, 3 })]
		public void Solution1_InvalidInput_Fail(int[] a1, int[] a2)
		{
			var node1 = Array2ListNode(a1);
			var node2 = Array2ListNode(a2);

			LeetCode.AddTwoNumbersSolution.Solution1(node1, node2);

			//return ListNode2Array(result);
		}


		private ListNode<int> Array2ListNode(int[] input)
		{
			ListNode<int> result = null;

			var current = result;

			foreach (var number in input)
			{
				if (current == null)
				{
					current = new ListNode<int> { Value = number };
					result = current;
				}
				else
				{
					current.Next = new ListNode<int> { Value = number };
					current = current.Next;
				}
			}

			return result;
		}

		private int[] ListNode2Array(ListNode<int> node)
		{
			var result = new List<int>();
			var temp = node;

			while (temp != null)
			{
				result.Add(temp.Value);
				temp = temp.Next;
			}

			return result.ToArray();
		}
	}
}
