using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
	public class Program
	{
		private static void Main(string[] args)
		{
			int[][] s = new int[3][];

			for (int i = 0; i < 3; i++)
			{
				s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
			}

			int result = FormingMagicSquare.formingMagicSquare(s);
		}
	}
}