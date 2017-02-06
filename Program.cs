using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxSequenceOfEqualElements
{
	public class MainClass
	{
		public static void Main()
		{
			var nums = Console.ReadLine()
			                  .Split(' ')
			                  .Select(int.Parse)
			                  .ToList<int>();

			var numList = new List<int>();
			var currNum = new List<int>();

			currNum.Add(nums[0]);

			for (int i = 1; i < nums.Count; i++)
			{
				if (nums[i] == currNum[0])
				{
					currNum.Add(nums[i]);
				}
				else
				{
					if (currNum.Count > numList.Count)
					{
						numList = new List<int>();

						for (int j = 0; j < currNum.Count; j++)
						{
							numList.Add(currNum[j]);
						}

					}

					currNum = new List<int>();
					currNum.Add(nums[i]);

				}
			}


			if (currNum.Count > numList.Count)
			{
				numList = new List<int>();

				for (int j = 0; j < currNum.Count; j++)
				{
					numList.Add(currNum[j]);
				}

			}

			Console.WriteLine(string.Join(" ", numList));

		}
	}
}
