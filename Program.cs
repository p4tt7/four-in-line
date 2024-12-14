using System;

class Program{
    public static bool Check(bool[,]matrix, int column, int row, int dc, int dr)
    {
        bool origen = matrix[row , column];
        for(int k=0; k<4; k++)
        {
            int new_col = column + k * dc;
            int new_row = row + k * dr;          
            if (new_row < 0 || new_col < 0 || new_row >= matrix.GetLength(0) || new_col >= matrix.GetLength(1))
            {
                return false;
            }

            if (matrix[new_row, new_col] != origen)
            {
                return false;
            }
        }
        return true;
    }

    public static bool HasFourInLine(bool[,] matrix)
    {
        int[] dr = new int[] {0, 1, 1, 1};
        int[] dc = new int[] {1, 1, 0, -1};
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int k = 0; k < dr.Length; k++)
                {
                    if (Check(matrix, column, row, dc[k], dr[k]))
                    {
                        return true;
                    }
                }
            }               
        }
        return false; 
    }

    private static void Main()
    {
    }
}
