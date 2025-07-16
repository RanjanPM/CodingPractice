
using System;
using System.Collections.Generic;

public class EncodeAndDecodeString
{
    // Encodes a list of strings to a single string.

    public static string Encode(List<string> strs)
    {
        if (strs == null || strs.Count == 0) return string.Empty;
        if (strs.Count == 1) return strs[0];
        var result = new System.Text.StringBuilder();
        for (int i = 0; i < strs.Count; i++)
        {
            result.Append(strs[i]);
            if (i != strs.Count - 1)
                result.Append("#");
        }
        return result.ToString();
    }

    // Decodes a single string to a list of strings.
    public static List<string> Decode(string s)
    {
        if (string.IsNullOrEmpty(s)) return new List<string>();
        var parts = s.Split('#');
        return new List<string>(parts);
    }
}
