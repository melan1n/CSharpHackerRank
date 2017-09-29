using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	static int[] getRecord(int[] s)
	{
		// Complete this function
		int highScoreBreak = 0;
		int lowScoreBreak = 0;

		int initialScore = s[0];

		int highScore = initialScore;
		int lowScore = initialScore;

		for (int i = 1; i < s.Length; i++)
		{
			if (s[i] > highScore)
			{
				highScoreBreak++;
				highScore = s[i];
			}
			if (s[i] < lowScore)
			{
				lowScoreBreak++;
				lowScore = s[i];
			}
		}
		int[] result = new int[] { highScoreBreak, lowScoreBreak };
		return result;
	}

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] s_temp = Console.ReadLine().Split(' ');
		int[] s = Array.ConvertAll(s_temp, Int32.Parse);
		int[] result = getRecord(s);
		Console.WriteLine(String.Join(" ", result));
	}
}
