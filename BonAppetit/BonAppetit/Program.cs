using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
	class Program
	{
		static int bonAppetit(int n, int k, int b, int[] ar)
		{
			// Complete this function
			int actualCost = 0;

			for (int i = 0; i < ar.Length; i++)
			{
				if (i != k)
				{
					actualCost += ar[i];
				}
			}
			actualCost /= 2; ;
			int result = b - actualCost;
			return result;
		}

		static void Main(String[] args)
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens_n[0]);
			int k = Convert.ToInt32(tokens_n[1]);
			string[] ar_temp = Console.ReadLine().Split(' ');
			int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
			int b = Convert.ToInt32(Console.ReadLine());
			int result = bonAppetit(n, k, b, ar);
			if (result == 0)
			{
				Console.WriteLine($"Bon Appetit");
			}
			else
			{
				Console.WriteLine(result);

			}
		}
		}

	}

