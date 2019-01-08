using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] candies)
        {
            int count = 1;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 2; col < candies.GetLength(1); col++)
                {
                    //...  
                    if ((candies[row, col] == candies[row, col - 2]) && (candies[row, col] == candies[row, col - 1]))
                    {
                        return true;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool ScoreColumnPresent(RegularCandies[,] candies)
        {
            int count = 1;
            for (int row = 0; row < candies.GetLength(0); row++)
            {
                for (int col = 0; col < candies.GetLength(1); col++)
                {
                    if ((row == 0) || (row == 1))
                    {
                        continue;
                    }
                    else if ((candies[row, col] == candies[row - 2, col]) && (candies[row, col] == candies[row - 1, col]))
                    {
                        count++;
                    }

                    if (count >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public enum RegularCandies
        {
            JellyBean = 1, LozengeOrange, LemonDropYellow, GumSquareGreen,
            LollipopHeadBlue, JujubeClusterPurple
        }
    }
    
}
