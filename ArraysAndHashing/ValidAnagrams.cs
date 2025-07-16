using System;

public class ValidAnagrams
{
    public static bool AreAnagrams(string s1, string s2, out string message)
    {
        if (s1.Length != s2.Length)
        {
            message = "Strings are not of same length, so they are not anagrams.";
            return false;
        }

        int[] charCounts = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            charCounts[s1[i] - 'a']++;
            charCounts[s2[i] - 'a']--;
        }

        foreach (int count in charCounts)
        {
            if (count != 0)
            {
                message = "Strings are not anagrams.";
                return false;
            }
        }

        message = "Strings are anagrams.";
        return true;
    }
    
}