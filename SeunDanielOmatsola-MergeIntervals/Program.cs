using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main(string[] args)
	{
		RunTests(); // I use this to Run the test cases and verify the MergeIntervals function
	}

	public static int[][] MergeIntervals(int[][] intervals)
	{
		// null or empty check, return an empty array
		if (intervals == null || intervals.Length == 0) return new int[0][];

		// Sort the intervals based on the start time
		Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

		var merged = new List<int[]> { intervals[0] }; // Initialize merged list with first interval

		foreach (var interval in intervals.Skip(1)) // Iterate over remaining intervals
		{
			var last = merged.Last(); // Get the last interval in merged list

			// Check if current interval overlaps with the last merged interval
			if (interval[0] <= last[1])
				last[1] = Math.Max(last[1], interval[1]); // Merge intervals by updating end time
			else
				merged.Add(interval); // No overlap, so add new interval to merged list
		}

		return [.. merged]; // Convert list to array and return
	}
















	// Method to test MergeIntervals function with various test cases
	public static void RunTests()
	{
		var testCases = new List<int[][]>
		{
			new int[][] { new int[] {1, 3}, new int[] {2, 6}, new int[] {8, 10}, new int[] {15, 18} },
			new int[][] { new int[] {1, 4}, new int[] {4, 5} },
			new int[][] { new int[] {5, 10}, new int[] {1, 3}, new int[] {2, 6}, new int[] {15, 18} },
			new int[][] { new int[] {1, 2}, new int[] {3, 4}, new int[] {5, 6} },
			Array.Empty<int[]>()
		};

		var expectedResults = new List<int[][]>
		{
			new int[][] { new int[] {1, 6}, new int[] {8, 10}, new int[] {15, 18} },
			new int[][] { new int[] {1, 5} },
			new int[][] { new int[] {1, 10}, new int[] {15, 18} },
			new int[][] { new int[] {1, 2}, new int[] {3, 4}, new int[] {5, 6} },
			Array.Empty<int[]>()
		};

		for (int i = 0; i < testCases.Count; i++)
		{
			var result = MergeIntervals(testCases[i]);
			Console.WriteLine("Test " + (i + 1) + ":");
			Console.WriteLine("Input: " + FormatIntervals(testCases[i]));
			Console.WriteLine("Expected Output: " + FormatIntervals(expectedResults[i]));
			Console.WriteLine("Actual Output: " + FormatIntervals(result));
			Console.WriteLine(AreEqual(result, expectedResults[i]) ? "✅ Passed" : "❌ Failed");
			Console.WriteLine("---------------------------------");
		}
	}

	// Helper method to compare two 2D arrays and check if they are equal
	private static bool AreEqual(int[][] a, int[][] b)
	{
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i][0] != b[i][0] || a[i][1] != b[i][1])
				return false;
		}
		return true;
	}

	// Helper method to format intervals as a string for better test display
	private static string FormatIntervals(int[][] intervals)
	{
		return "[" + string.Join(", ", intervals.Select(i => $"[{i[0]}, {i[1]}]")) + "]";
	}
}
