using System;

public class BestTimeToBuySellStock
{
    // Solves the problem with cooldown
    public static int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length == 0) return 0;
        int n = prices.Length;
        int[] hold = new int[n]; // Max profit if holding stock
        int[] sold = new int[n]; // Max profit if just sold stock
        int[] rest = new int[n]; // Max profit if in cooldown

        hold[0] = -prices[0];
        sold[0] = 0;
        rest[0] = 0;

        for (int i = 1; i < n; i++)
        {
            hold[i] = Math.Max(hold[i - 1], rest[i - 1] - prices[i]);
            sold[i] = hold[i - 1] + prices[i];
            rest[i] = Math.Max(rest[i - 1], sold[i - 1]);
        }
        return Math.Max(sold[n - 1], rest[n - 1]);
    }
}
