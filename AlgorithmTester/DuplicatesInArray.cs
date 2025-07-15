using System;
using System.Collections.Generic;

public class DuplicatesInArray
{
    public static bool HasDuplicates(int[] numbers)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in numbers)
        {
            if (!seen.Add(num))
            {
                return true;
            }
        }
        return false;
    }
}