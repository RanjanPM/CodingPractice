using System;

public class TrappingRainWater
{
    public static int Trap(int[] height)
    {
        int n = height.Length;
        if (n == 0) return 0;
        int left = 0, right = n - 1;
        int leftMax = 0, rightMax = 0, water = 0;
        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                    leftMax = height[left];
                else
                    water += leftMax - height[left];
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                    rightMax = height[right];
                else
                    water += rightMax - height[right];
                right--;
            }
        }
        return water;
    }
}
