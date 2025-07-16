using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Algorithm Testing Program ===");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Test HasDuplicates method");
        Console.WriteLine("2. Test AreAnagrams method");
        Console.WriteLine("3. Test TwoSumSolver method");
        Console.WriteLine("4. Test GroupAnagrams method");
        Console.WriteLine("5. Test TopKFrequentElements method");
        Console.WriteLine("6. Test GetProductExceptSelf method");
        Console.WriteLine("7. Test IsValidSudoku method");
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
            case "3":
                TestTwoSumSolver();
                break;
            case "4":
                TestGroupAnagrams();
                break;
            case "5":
                TestTopKFrequentElements();
                break;
            case "6":
                TestProductExceptSelf();
                break;
            case "7":
                TestIsValidSudoku();
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

    private static void TestIsValidSudoku()
    {
        Console.WriteLine("\n=== Testing IsValidSudoku Method ===");

        char[][] validBoard = new char[][]
        {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };
        bool isValid = ValidSoduku.IsValidSudoku(validBoard);
        Console.WriteLine($"Sample valid board: {isValid}");

        char[][] invalidBoard = new char[][]
        {
            new char[] {'8','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };
        bool isInvalid = ValidSoduku.IsValidSudoku(invalidBoard);
        Console.WriteLine($"Sample invalid board: {isInvalid}");
    }
    private static void TestProductExceptSelf()
    {
        Console.WriteLine("\n=== Testing GetProductExceptSelf Method ===");

        // Test cases
        int[] nums = { 1, 2, 3, 4 };
        int[] result = ProductExceptSelf.GetProductExceptSelf(nums);
        Console.WriteLine($"Input: [1, 2, 3, 4] => Output: [{string.Join(", ", result)}]");

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated numbers (e.g., 1,2,3,4): ");
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
                int[] userResult = ProductExceptSelf.GetProductExceptSelf(userArray);
                Console.WriteLine($"Output: [{string.Join(", ", userResult)}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing input: {ex.Message}");
            }
        }
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

    private static void TestTwoSumSolver()
    {
        Console.WriteLine("\n=== Testing TwoSumSolver Method ===");

        // Test cases
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;

        int[] result1 = TwoSumSolver.TwoSum(nums1, target1);
        int[] result2 = TwoSumSolver.TwoSum(nums2, target2);

        Console.WriteLine($"TwoSum([2, 7, 11, 15], 9) => [{string.Join(", ", result1)}]");
        Console.WriteLine($"TwoSum([3, 2, 4], 6) => [{string.Join(", ", result2)}]");

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated numbers (e.g., 2,7,11,15): ");
        string? userInput = Console.ReadLine();
        Console.Write("Enter target value: ");
        string? targetInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userInput) && !string.IsNullOrWhiteSpace(targetInput) && int.TryParse(targetInput, out int userTarget))
        {
            try
            {
                string[] parts = userInput.Split(',');
                int[] userNums = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    userNums[i] = int.Parse(parts[i].Trim());
                }

                int[] userResult = TwoSumSolver.TwoSum(userNums, userTarget);
                Console.WriteLine($"TwoSum([{string.Join(", ", userNums)}], {userTarget}) => [{string.Join(", ", userResult)}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing input: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers and target.");
        }
    }

    private static void TestGroupAnagrams()
    {
        Console.WriteLine("\n=== Testing GroupAnagrams Method ===");

        // Test cases
        string[] words1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var grouped1 = GroupAnagrams.GroupAnagramsByIndexArray(words1);

        Console.WriteLine("GroupAnagrams([\"eat\", \"tea\", \"tan\", \"ate\", \"nat\", \"bat\"]):");
        Console.WriteLine(string.Join(", ", grouped1.Select(g => $"[{string.Join(", ", g)}]")));

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated words (e.g., eat,tea,tan,ate,nat,bat): ");
        string? userInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userInput))
        {
            try
            {
                string[] userWords = userInput.Split(',');
                for (int i = 0; i < userWords.Length; i++)
                {
                    userWords[i] = userWords[i].Trim();
                }

                var userGrouped = GroupAnagrams.GroupAnagramsByIndexArray(userWords);
                Console.WriteLine("Grouped anagrams:");
                Console.WriteLine(string.Join(", ", userGrouped.Select(g => $"[{string.Join(", ", g)}]")));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing input: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid words.");
        }
    }

    private static void TestTopKFrequentElements()
    {
        Console.WriteLine("\n=== Testing TopKFrequentElements Method ===");

        // Test case
        int[] nums = { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        int[] result = TopKFrequentElements.TopKFrequent(nums, k);
        Console.WriteLine($"TopKFrequent([1, 1, 1, 2, 2, 3], 2) => [{string.Join(", ", result)}]");

        // Interactive test
        Console.WriteLine("\n--- Custom Test ---");
        Console.Write("Enter comma-separated numbers (e.g., 1,1,1,2,2,3): ");
        string? userInput = Console.ReadLine();
        Console.Write("Enter k value: ");
        string? kInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userInput) && !string.IsNullOrWhiteSpace(kInput) && int.TryParse(kInput, out int userK))
        {
            try
            {
                string[] parts = userInput.Split(',');
                int[] userNums = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    userNums[i] = int.Parse(parts[i].Trim());
                }

                int[] userResult = TopKFrequentElements.TopKFrequent(userNums, userK);
                Console.WriteLine($"TopKFrequent([{string.Join(", ", userNums)}], {userK}) => [{string.Join(", ", userResult)}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing input: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers and k value.");
        }
    }
}