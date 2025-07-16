using System;
using System.Collections.Generic;

public class TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
            return Array.Empty<int>();
        if (k == nums.Length)
            return nums;
        // Step 1: Count frequencies
        var freqDict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freqDict.ContainsKey(num))
                freqDict[num]++;
            else
                freqDict[num] = 1;
        }

        // Step 2: Use a min-heap (priority queue) to keep top k frequent elements
        var pq = new PriorityQueue<int, int>(); // int: element, int: frequency

        foreach (var kvp in freqDict)
        {
            pq.Enqueue(kvp.Key, kvp.Value);
            if (pq.Count > k)
                pq.Dequeue();
        }

        // Step 3: Extract elements from the priority queue
        var result = new int[k];
        for (int i = k - 1; i >= 0; i--)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}