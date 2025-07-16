using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== TwoPointers Project ===");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Test ValidPalindrome");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");

        string? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                TestValidPalindrome();
                break;
            case "0":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
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
