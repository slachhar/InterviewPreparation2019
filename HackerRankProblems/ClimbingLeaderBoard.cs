using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public class ClimbingLeaderBoard
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            Dictionary<int, int> leaderBoard = new Dictionary<int, int>();
            int rank = 1;
            for (int i = 0; i < scores.Length; i++)
            {
                if (i != 0 && scores[i] < scores[i - 1])
                    rank++;
                leaderBoard.Add(rank, scores[i]);
            }

            return new int[alice.Length];
        }
    }
}
