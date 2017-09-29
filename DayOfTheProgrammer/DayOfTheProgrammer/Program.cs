using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	static string solve(int year)
	{
		// Complete this function
		string result = string.Empty;

		string month = "09";
		int day = 0;
		int daysToSept = 0;

		if (year >= 1919 && ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))))
		{
			daysToSept = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
			day = 256 - daysToSept;
		}
		else if (year >= 1919 && ((year % 400 != 0) || ((year % 4 != 0 && year % 100 == 0))))
		{
			daysToSept = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
			day = 256 - daysToSept;
		}
		else if (year == 1918)
		{
			daysToSept = 31 + 15 + 31 + 30 + 31 + 30 + 31 + 31;
			day = 256 - daysToSept;
		}
		else if ((year < 1918) && (year % 4 == 0)) 
		{
			daysToSept = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
			day = 256 - daysToSept;
		}
		else if (year < 1918 && year % 4 != 0)
		{
			daysToSept = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
			day = 256 - daysToSept;
		}

		result = day + "." + month + "." + year;
		return result;
	}

	static void Main(String[] args)
	{
		int year = Convert.ToInt32(Console.ReadLine());
		string result = solve(year);
		Console.WriteLine(result);
	}
}
