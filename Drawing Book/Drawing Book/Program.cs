using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Book
{
	class Program
	{
		static int solve(int n, int p)
		{
			// Complete this function
			int pagesTurnsFromStart = 0 ;
			int pagesTurnsFromEnd = 0;
			if (p % 2 == 1)
			{
				pagesTurnsFromStart = (p - 1)/2;
				if (n % 2 == 0)
				{
					pagesTurnsFromEnd = (int)Math.Ceiling((double)((double)n - p) / 2);
				}
				else
				{
					pagesTurnsFromEnd = (n - p) / 2;
				}
			}
			else if (p % 2 == 0)
			{
				pagesTurnsFromStart = p / 2;
				if (n % 2 == 0)
				{
					pagesTurnsFromEnd = (n - p) / 2;
				}
				else
				{
					pagesTurnsFromEnd = (n - 1 - p) / 2;
				}
			}
			return (int)Math.Min(pagesTurnsFromStart, pagesTurnsFromEnd);
		}

		static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int p = Convert.ToInt32(Console.ReadLine());
			int result = solve(n, p);
			Console.WriteLine(result);
		}

	}
}
