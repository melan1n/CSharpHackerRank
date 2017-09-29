using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

	static int getTotalX(int[] a, int[] b)
	{
		// Complete this function
		Array.Sort(a);
		int minResult = a[a.Length - 1];
		Array.Sort(b);
		int maxResult = b[0];

		int count = 0;

		for (int i = minResult; i <= maxResult; i+= minResult)
		{
			for (int j = 0; j < a.Length; j++)
			{
				if (i % a[j] != 0)
				{
					break;
				}
				else
				{
					continue;
				}
			}
			for (int k = 0; k < b.Length; k++)
			{
				if (b[k] % i != 0)
				{
					break;
				}
				else if (k == b.Length - 1)
				{
					count++;
				}
			}


		}
		return count;
	}

	static void Main(String[] args)
	{
		string[] tokens_n = Console.ReadLine().Split(' ');
		int n = Convert.ToInt32(tokens_n[0]);
		int m = Convert.ToInt32(tokens_n[1]);
		string[] a_temp = Console.ReadLine().Split(' ');
		int[] a = Array.ConvertAll(a_temp, Int32.Parse);
		string[] b_temp = Console.ReadLine().Split(' ');
		int[] b = Array.ConvertAll(b_temp, Int32.Parse);
		int total = getTotalX(a, b);
		Console.WriteLine(total);
	}
}
