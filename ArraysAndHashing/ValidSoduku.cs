
using System;
using System.Collections.Generic;

public class ValidSoduku
{
    // board is a 9x9 char array, empty cells are '.'
    public static bool IsValidSudoku(char[][] board)
    {
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char c = board[i][j];
                if (c == '.') continue;
                string rowKey = $"{c} in row {i}";
                string colKey = $"{c} in col {j}";
                string boxKey = $"{c} in box {i / 3}-{j / 3}";
                if (!seen.Add(rowKey) || !seen.Add(colKey) || !seen.Add(boxKey))
                    return false;
            }
        }
        return true;
    }
}
