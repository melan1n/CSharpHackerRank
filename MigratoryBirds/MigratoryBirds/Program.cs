using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	static int migratoryBirds(int n, int[] ar)
	{
		// Complete this function
		int[] result = new int[n];
		int maxFrequency = 0; 
		int maxFrequencyIndex = 0;
		for (int i = 0; i < ar.Length; i++)
		{
			result[ar[i] - 1]++;
		}
		
		for (int j = 0; j < result.Length; j++)
		{
			if (result[j] > maxFrequency)
			{
				maxFrequency = result[j];
				maxFrequencyIndex = j+1;
			}
		}
		return maxFrequencyIndex;
	}

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] ar_temp = Console.ReadLine().Split(' ');
		int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
		int result = migratoryBirds(n, ar);
		Console.WriteLine(result);
	}
}
