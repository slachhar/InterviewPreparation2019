using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
	public static class FormingMagicSquare
	{
		//5 3 4
		//1 5 8
		//6 4 2
		public static int formingMagicSquare(int[][] s)
		{
			int[,,] magicsquarePossibilties = new int[8, 3, 3]  { { { 8, 1, 6 }, { 3,5,7}, { 4, 9, 2 } },
																{ { 6,1,8},{ 7,5,3},{ 2,9,4 } },
																{ { 4,9,2},{ 3,5,7},{ 8,1,6 } },
																{ { 2,9,4},{ 7,5,3},{ 6,1,8} },
																{ { 8,3,4},{ 1,5,9},{ 6,7,2 } },
																{ { 4,3,8},{ 9,5,1},{ 2,7,6} },
																{ { 6,7,2},{ 1,5,9},{ 8,3,4 } },
																{ { 2,7,6},{ 9,5,1},{ 4,3,8 } } };
			//{8,1,6,3,5,7,4,9,2 },

			List<int> TotalCost = new List<int>();
			for (int k = 0; k < magicsquarePossibilties.GetLength(0); k++)
			{
				TotalCost.Add(0);
				for (int i = 0; i < s.Length; i++)
				{
					for (int j = 0; j < s[i].Length; j++)
					{
						TotalCost[k] += Math.Abs(magicsquarePossibilties[k, i, j] - s[i][j]);
					}
				}
			}

			int min = TotalCost.Min();
			return min;
		}

	}
}
