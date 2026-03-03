//using System;
//namespace FlattenBinarySearch;
//class GfG
//{

//    // function to binary search for x in arr[]
//   public static bool Search(int[] arr, int x)
//    {
//        int lo = 0, hi = arr.Length - 1;

//        while (lo <= hi)
//        {
//            int mid = (lo + hi) / 2;

//            if (x == arr[mid])
//                return true;
//            if (x < arr[mid])
//                hi = mid - 1;
//            else
//                lo = mid + 1;
//        }
//        return false;
//    }

//    // function to search element x in fully 
//    // sorted matrix
//    public bool SearchMatrix(int[][] mat, int x)
//    {
//        int n = mat.Length, m = mat[0].Length;
//        int lo = 0, hi = n - 1;
//        int row = -1;

//        while (lo <= hi)
//        {
//            int mid = (lo + hi) / 2;

//            // if the first element of mid row is equal to x,
//            // return true
//            if (x == mat[mid][0])
//                return true;

//            // if x is greater than first element of mid row,
//            // store the mid row and search in lower half
//            if (x > mat[mid][0])
//            {
//                row = mid;
//                lo = mid + 1;
//            }

//            // if x is smaller than first element of mid row,
//            // search in upper half
//            else
//                hi = mid - 1;
//        }

//        // if x is smaller than all elements of mat[][]
//        if (row == -1)
//            return false;

//        return Search(mat[row], x);
//    }


//}
using System;

class GfG
{

    // function to search for x in the matrix 
    // using binary search
    public  bool searchMatrix(int[,] mat, int x)
    {
        int n = mat.GetLength(0), m = mat.GetLength(1);

        int lo = 0, hi = n * m - 1;
        while (lo <= hi)
        {
            int mid = (lo + hi) / 2;

            // find row and column of element at mid index
            int row = mid / m;
            int col = mid % m;

            // if x is found, return true
            if (mat[row, col] == x)
                return true;

            // if x is greater than mat[row, col], search
            // in right half
            if (mat[row, col] < x)
                lo = mid + 1;

            // if x is less than mat[row, col], search 
            // in left half
            else
                hi = mid - 1;
        }
        return false;
    }


}