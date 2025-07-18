using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select test case:");
        Console.WriteLine("1: BestTimeToBuySellStock");
        string choice = Console.ReadLine() ?? string.Empty;
        switch (choice)
        {
            case "1":
                TestBestTimeToBuySellStock();
                break;
            default:
                Console.WriteLine("Invalid choice or not implemented yet.");
                break;
        }
    }

    static void TestBestTimeToBuySellStock()
    {
        int[] prices = {1, 2, 3, 0, 2};
        int profit = BestTimeToBuySellStock.MaxProfit(prices);
        Console.WriteLine($"Max Profit: {profit}"); // Expected: 3
    }
}

