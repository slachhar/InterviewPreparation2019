using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
	public class Program
	{
		//5 3 4
		//1 5 8
		//6 4 2
		static int formingMagicSquare(int[][] s)
		{
			int[,] magicsquarePossibilties = new int[8, 9]{
												{8,1,6,3,5,7,4,9,2 },
												{6,1,8,7,5,3,2,9,4 },
												{4,9,2,3,5,7,8,1,6 },
												{2,9,4,7,5,3,6,1,8 },
												{8,3,4,1,5,9,6,7,2 },
												{4,3,8,9,5,1,2,7,6 },
												{6,7,2,1,5,9,8,3,4 },
												{2,7,6,9,5,1,4,3,8 }};
			int TotalCost = 0;
			for (int i = 0; i < s.Length; i++)
			{
				for (int j = 0; j < s[i].Length; j++)
				{
					//TotalCost += (magicsquarePossibilties[])
				}
			}
			return 0;
		}

		static void Main(string[] args)
		{			
			int[][] s = new int[3][];

			for (int i = 0; i < 3; i++)
			{
				s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
			}

			int result = formingMagicSquare(s);
		}
	}
}
