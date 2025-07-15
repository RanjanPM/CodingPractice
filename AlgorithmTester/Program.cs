using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Algorithm Testing Program ===");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Test HasDuplicates method");
        Console.WriteLine("2. Test AreAnagrams method");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");

        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                TestHasDuplicates();
                break;
            case "2":
                TestAreAnagrams();
                break;
            case "0":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        // Keep console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    private static void TestHasDuplicates()
    {
        Console.WriteLine("\n=== Testing HasDuplicates Method ===");

        // Test cases
        int[] arrayWithDuplicates = { 1, 2, 3, 2, 4 };
        int[] arrayWithoutDuplicates = { 1, 2, 3, 4, 5 };
        int[] emptyArray = { };
        int[] singleElement = { 1 };

        Console.WriteLine($"Array [1, 2, 3, 2, 4] has duplicates: {DuplicatesInArray.HasDuplicates(arrayWithDuplicates)}");
        Console.WriteLine($"Array [1, 2, 3, 4, 5] has duplicates: {DuplicatesInArray.HasDuplicates(arrayWithoutDuplicates)}");
        Console.WriteLine($"Empty array has duplicates: {DuplicatesInArray.HasDuplicates(emptyArray)}");
        Console.WriteLine($"Single element array [1] has duplicates: {DuplicatesInArray.HasDuplicates(singleElement)}");

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated numbers (e.g., 1,2,3,2): ");
        string? userInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userInput))
        {
            try
            {
                string[] parts = userInput.Split(',');
                int[] userArray = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    userArray[i] = int.Parse(parts[i].Trim());
                }

                bool result = DuplicatesInArray.HasDuplicates(userArray);
                Console.WriteLine($"Your array [{string.Join(", ", userArray)}] has duplicates: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing input: {ex.Message}");
            }
        }
    }

    private static void TestAreAnagrams()
    {
        Console.WriteLine("\n=== Testing AreAnagrams Method ===");

        // Test cases
        string s1 = "listen";
        string s2 = "silent";
        string s3 = "hello";
        string s4 = "world";

        string msg1, msg2;
        bool res1 = ValidAnagrams.AreAnagrams(s1, s2, out msg1);
        bool res2 = ValidAnagrams.AreAnagrams(s3, s4, out msg2);

        Console.WriteLine($"Are \"{s1}\" and \"{s2}\" anagrams? {res1}. {msg1}");
        Console.WriteLine($"Are \"{s3}\" and \"{s4}\" anagrams? {res2}. {msg2}");

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter first string: ");
        string? userStr1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string? userStr2 = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userStr1) && !string.IsNullOrWhiteSpace(userStr2))
        {
            string userMsg;
            bool result = ValidAnagrams.AreAnagrams(userStr1!, userStr2!, out userMsg);
            Console.WriteLine($"Are \"{userStr1}\" and \"{userStr2}\" anagrams? {result}. {userMsg}");
        }
        else
        {
            Console.WriteLine("Invalid input. Both strings are required.");
        }
    }
}
