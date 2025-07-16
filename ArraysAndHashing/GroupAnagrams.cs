using System;
using System.Collections.Generic;
using System.Text;

public class GroupAnagrams
{
    public static IList<IList<string>> GroupAnagramsByIndexArray(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            int[] indexArray = new int[26];
            foreach (char c in str)
            {
                indexArray[c - 'a']++;
            }

            // Convert indexArray to a string key
            var keyBuilder = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                keyBuilder.Append(indexArray[i]);
                keyBuilder.Append('#'); // Separator to avoid ambiguity
            }
            string key = keyBuilder.ToString();

            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }
            dict[key].Add(str);
        }

        var result = new List<IList<string>>();
        foreach (var entry in dict.Values)
        {
            result.Add(entry);
        }
        return result;
    }
}