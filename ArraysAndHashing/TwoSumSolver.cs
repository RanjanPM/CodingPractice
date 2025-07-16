using System;
using System.Collections.Generic;

public class TwoSumSolver
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            // If the current element itself is the target, return its index
            if (nums[i] == target)
                return new int[] { i };

            int remainder = target - nums[i];
            if (map.ContainsKey(remainder))
            {
                return new int[] { map[remainder], i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }
        // Return empty array if no solution found
        return new int[0];
    }
   
}