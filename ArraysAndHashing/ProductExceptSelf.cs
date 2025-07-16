using System;

public class ProductExceptSelf
{
    public static int[] GetProductExceptSelf(int[] nums)
    {
        int n = nums.Length;

        int[] finalarray = new int[n];
        Array.Fill(finalarray, 1);

        // First pass: compute prefix products
        int pre = 1;
        for (int i = 0; i < n; i++)
        {
            finalarray[i] = pre;
            pre *= nums[i];
        }

        // Second pass: compute postfix products and multiply
        int post = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            finalarray[i] *= post;
            post *= nums[i];
        }

        return finalarray;
    }

}