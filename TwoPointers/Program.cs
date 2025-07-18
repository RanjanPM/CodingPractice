using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== TwoPointers Project ===");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Test ValidPalindrome");
        Console.WriteLine("2. Test TwoSumTwo");
        Console.WriteLine("3. Test ThreeSum");
        Console.WriteLine("4. Test ContainerWithMostWater");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");

        string? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                TestValidPalindrome();
                break;
            case "2":
                TestTwoSumTwo();
                break;
            case "3":
                TestThreeSum();
                break;
            case "4":
                TestContainerWithMostWater();
                break;
            case "0":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private static void TestContainerWithMostWater()
    {
        Console.WriteLine("\n=== Testing ContainerWithMostWater ===");
        int[] height = {1,8,6,2,5,4,8,3,7};
        int maxArea = ContainerWithMostWater.MaxArea(height);
        Console.WriteLine("Input: [1,8,6,2,5,4,8,3,7]");
        Console.WriteLine($"Max Area: {maxArea}");

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated heights (e.g., 1,8,6,2,5,4,8,3,7): ");
        string? userInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userInput))
        {
            try
            {
                string[] parts = userInput.Split(',');
                int[] userHeights = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    userHeights[i] = int.Parse(parts[i].Trim());
                }
                int userMaxArea = ContainerWithMostWater.MaxArea(userHeights);
                Console.WriteLine($"Max Area: {userMaxArea}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    private static void TestThreeSum()
    {
        Console.WriteLine("\n=== Testing ThreeSum ===");
        int[] nums = {-1, 0, 1, 2, -1, -4};
        var result = ThreeSum.FindThreeSum(nums);
        Console.WriteLine("Input: [-1, 0, 1, 2, -1, -4]");
        Console.WriteLine("Triplets:");
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated numbers (e.g., -1,0,1,2,-1,-4): ");
        string? userInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userInput))
        {
            try
            {
                string[] parts = userInput.Split(',');
                int[] userNums = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    userNums[i] = int.Parse(parts[i].Trim());
                }
                var userResult = ThreeSum.FindThreeSum(userNums);
                Console.WriteLine("Triplets:");
                foreach (var triplet in userResult)
                {
                    Console.WriteLine($"[{string.Join(", ", triplet)}]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    private static void TestTwoSumTwo()
    {
        Console.WriteLine("\n=== Testing TwoSumTwo ===");
        int[] numbers = {2, 7, 11, 15};
        int target = 9;
        int[] result = TwoSumTwo.TwoSum(numbers, target);
        Console.WriteLine($"Input: [2, 7, 11, 15], target = 9 => Output: [{result[0]}, {result[1]}]");

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated sorted numbers (e.g., 2,7,11,15): ");
        string? userInput = Console.ReadLine();
        Console.Write("Enter target value: ");
        string? targetInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userInput) && !string.IsNullOrWhiteSpace(targetInput) && int.TryParse(targetInput, out int userTarget))
        {
            try
            {
                string[] parts = userInput.Split(',');
                int[] userNumbers = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    userNumbers[i] = int.Parse(parts[i].Trim());
                }
                int[] userResult = TwoSumTwo.TwoSum(userNumbers, userTarget);
                Console.WriteLine($"Output: [{userResult[0]}, {userResult[1]}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    private static void TestValidPalindrome()
    {
        Console.WriteLine("\n=== Testing ValidPalindrome ===");
        string[] testCases = {
            "A man, a plan, a canal: Panama",
            "race a car",
            " ",
            "0P"
        };
        foreach (var s in testCases)
        {
            bool result = ValidPalindrome.IsPalindrome(s);
            Console.WriteLine($"Input: \"{s}\" => Output: {result}");
        }

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter a string to check for palindrome: ");
        string? userInput = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userInput))
        {
            bool userResult = ValidPalindrome.IsPalindrome(userInput);
            Console.WriteLine($"Output: {userResult}");
        }
    }
}
