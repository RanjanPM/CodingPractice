using System;
using System.Collections.Generic;

public class ThreeSum
{
    public static IList<IList<int>> FindThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        int n = nums.Length;
        for (int i = 0; i < n - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // skip duplicates
            int left = i + 1, right = n - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]) left++; // skip duplicates
                    while (left < right && nums[right] == nums[right + 1]) right--; // skip duplicates
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return result;
    }
}
