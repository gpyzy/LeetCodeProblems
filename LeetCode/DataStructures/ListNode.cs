using System;
namespace LeetCode.DataStructures
{
	public class ListNode<T>
	{
		
		public T Value
		{
			get;
			set;
		}

		public ListNode<T> Next
		{
			get;
			set;
		}

		public int Length()
		{
			var result = 1;
			var root = this;
			while (root.Next != null)
			{
				result++;
				root = root.Next;
			}

			return result;
		}
	}
}
