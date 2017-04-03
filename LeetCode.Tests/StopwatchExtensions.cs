using System;
using System.Diagnostics;

namespace LeetCode.Tests
{
	public static class StopwatchExtensions
	{
		public static long Time(this Stopwatch sw, Action action, int iterations)
		{
			sw.Reset();
			sw.Start();
			for (int i = 0; i < iterations; i++)
			{
				action();
			}
			sw.Stop();

			return sw.ElapsedMilliseconds;
		}

		public static void LogResult(this Stopwatch sw, Action action, int iterations, string message)
		{
			var time = sw.Time(action, iterations);

			Console.WriteLine(message + ": " + time.ToString());
		}
	}
}
