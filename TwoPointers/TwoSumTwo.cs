using System;

public class TwoSumTwo
{
    // Returns 1-based indices
    public static int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
                return new int[] { left + 1, right + 1 };
            else if (sum < target)
                left++;
            else
                right--;
        }
        // The problem guarantees exactly one solution
        throw new ArgumentException("No solution found");
    }
}
