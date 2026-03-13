using System;
using System.Collections.Generic;
using System.Text;

namespace TopLeftOrBottomRight
{
    internal class TopRight
    {
       
    
        public static bool SearchTopRight(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int r = 0;
            int c = cols - 1; // top-right corner

            while (r < rows && c >= 0)
            {
                if (matrix[r, c] == target)
                    return true;

                if (target < matrix[r, c])
                    c--;        // move left
                else
                    r++;        // move down
            }

            return false;
        }
    }

}

