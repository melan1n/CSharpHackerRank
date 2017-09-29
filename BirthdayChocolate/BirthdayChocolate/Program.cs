using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	static int solve(int n, int[] s, int d, int m)
	{
		// Complete this function
		int result = 0;

		for (int start = 0; start <= s.Length - m; start++)
		{
			if ((m==1) && (s[start] == d))
			{
				result++;
			}
			else
			{
				int sum = s[start];
				for (int end = start + 1; end < start + m; end++)
				{
					sum += s[end];
				}
				if (sum == d)
				{
					result++;
				}
			}
			
		}

		return result;
	}

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] s_temp = Console.ReadLine().Split(' ');
		int[] s = Array.ConvertAll(s_temp, Int32.Parse);
		string[] tokens_d = Console.ReadLine().Split(' ');
		int d = Convert.ToInt32(tokens_d[0]);
		int m = Convert.ToInt32(tokens_d[1]);
		int result = solve(n, s, d, m);
		Console.WriteLine(result);
	}
}
