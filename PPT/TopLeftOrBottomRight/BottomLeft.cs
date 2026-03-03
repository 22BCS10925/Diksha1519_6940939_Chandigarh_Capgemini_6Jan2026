using System;
using System.Collections.Generic;
using System.Text;

namespace TopLeftOrBottomRight
{
    internal class BottomLeft
    {
   
        public static bool SearchBottomLeft(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int r = rows - 1;
            int c = 0; // bottom-left corner

            while (r >= 0 && c < cols)
            {
                if (matrix[r, c] == target)
                    return true;

                if (target < matrix[r, c])
                    r--;        // move up
                else
                    c++;        // move right
            }

            return false;
        }
    }

}

