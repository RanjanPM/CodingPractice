using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Algorithm Testing Program ===");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Test HasDuplicates method");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                TestHasDuplicates();
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
        string userInput = Console.ReadLine();
        
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
}
