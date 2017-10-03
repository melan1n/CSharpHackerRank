using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string steps = Console.ReadLine();
			int[] stepsDirections = new int[n];   //create an int array for steps (+/-1)

			for (int i = 0; i < n; i++)
			{
				if (steps[i] == 'U')
				{
					stepsDirections[i] = 1;
				}
				else
				{
					stepsDirections[i] = -1;
				}
			}
			int valleyCount = 0;				//have a counter of valleys
			int levelAtPreviousStep = 0;        //have a previous-step level meter
			int levelAtCurrentStep = 0;         //have a current-step level meter
			for (int i = 0; i < n; i++)         //track all occurrences of negative to 0 level and increment valley counter 
			{
				levelAtCurrentStep = levelAtPreviousStep + stepsDirections[i];
				if (levelAtPreviousStep < 0 && levelAtCurrentStep == 0)
				{
					valleyCount++;
				}
				levelAtPreviousStep = levelAtCurrentStep;
			}
			Console.WriteLine(valleyCount);
		}
	}
}
