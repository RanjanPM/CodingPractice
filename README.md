# CodingPractice


## Arrays and Hashing

This section covers a variety of classic problems that can be solved efficiently using arrays and hash-based data structures. The most common patterns are:

- **HashSet**: Used for fast existence checks and to avoid duplicates.
- **Dictionary/HashMap**: Used for counting frequencies, mapping values to indices, or grouping items.
- **Sorting/Two Pointers**: Sometimes used for problems involving order or sequence.
- **Prefix/Suffix Arrays**: Used for cumulative computations without extra loops.

### Common Patterns

1. **Use a HashSet to check for duplicates or to track seen elements.**
2. **Use a Dictionary to count frequencies or map values to indices.**
3. **For grouping or anagram problems, use a canonical representation (like a sorted string or character count array) as a key in a Dictionary.**
4. **For sequence or range problems, use a HashSet to quickly check for the start of a sequence.**
5. **For prefix/suffix product or sum, use extra arrays or variables to accumulate results in one or two passes.**


### Problem Summaries & Examples


**DuplicatesInArray.cs**: Checks if an array contains any duplicate integers.
**How**: Uses a HashSet to track seen numbers. For each number, if it is already in the set, a duplicate is found.
**Pattern**: Existence check with HashSet.
**Example**:
```csharp
Input: [1, 2, 3, 2, 4]
Output: true
```


**EncodeAndDecodeString.cs**: Encodes a list of strings into a single string by appending '#' after each string except the last, and decodes by splitting on '#'.
**How**: Concatenate each string with a '#' separator, then split on '#' to decode.
**Pattern**: String manipulation and delimiter-based encoding/decoding.
**Example**:
```csharp
Input: ["leet", "code", "practice"]
Encoded: "leet#code#practice"
Decoded: ["leet", "code", "practice"]
```


**GroupAnagrams.cs**: Groups a list of strings into anagrams.
**How**: For each string, count the frequency of each character and use this as a key in a Dictionary to group anagrams.
**Pattern**: Grouping by canonical form using Dictionary.
**Example**:
```csharp
Input: ["eat", "tea", "tan", "ate", "nat", "bat"]
Output: [["eat", "tea", "ate"], ["tan", "nat"], ["bat"]]
```


**LongestConsecutiveSequence.cs**: Finds the length of the longest consecutive sequence in an unsorted array.
**How**: Insert all numbers into a HashSet. For each number, if it is the start of a sequence (num-1 not in set), count the streak length.
**Pattern**: Sequence detection with HashSet.
**Example**:
```csharp
Input: [100, 4, 200, 1, 3, 2]
Output: 4 // (sequence: 1,2,3,4)
```


**ProductExceptSelf.cs**: Returns an array where each element is the product of all other elements, without using division.
**How**: Use two passes: one to accumulate prefix products, another for suffix products, multiplying as you go.
**Pattern**: Prefix/suffix accumulation.
**Example**:
```csharp
Input: [1, 2, 3, 4]
Output: [24, 12, 8, 6]
```


**TopKFrequentElements.cs**: Finds the k most frequent elements in an array.
**How**: Count frequencies with a Dictionary, then use a min-heap to keep the k most frequent.
**Pattern**: Frequency counting with Dictionary and heap.
**Example**:
```csharp
Input: [1,1,1,2,2,3], k = 2
Output: [1,2]
```


**TwoSumSolver.cs**: Finds indices of two numbers that add up to a target value.
**How**: For each number, check if (target - num) exists in a Dictionary. If so, return indices.
**Pattern**: Complement search with Dictionary.
**Example**:
```csharp
Input: [2, 7, 11, 15], target = 9
Output: [0, 1] // (2 + 7 = 9)
```


**ValidAnagrams.cs**: Checks if two strings are anagrams by comparing character counts in an array.
**How**: Count the frequency of each character in both strings and compare the counts.
**Pattern**: Character counting with array.
**Example**:
```csharp
Input: "anagram", "nagaram"
Output: true
```


**ValidSoduku.cs**: Validates a partially filled 9x9 Sudoku board.
**How**: For each filled cell, use a HashSet to track if the digit has already appeared in the same row, column, or 3x3 box (using composite keys).
**Pattern**: Uniqueness check with HashSet and composite keys.
**Example**:
```csharp
Input: (see LeetCode 36 for board example)
Output: true or false depending on board validity
```

---


**Key Takeaway:**
Most array and hashing problems can be solved by:
- Using HashSet for fast existence/uniqueness checks.
- Using Dictionary for counting, mapping, or grouping.
- Using prefix/suffix arrays or variables for cumulative computations.

**Tips for Success:**
- Always look for opportunities to use a HashSet or Dictionary for O(1) lookups.
- For grouping, use a canonical form as a key.
- For sequence/range problems, check for sequence starts, not every element.
- For product/sum except self, use prefix/suffix tricks to avoid nested loops.

Recognizing and practicing these patterns will help you solve a wide range of array and hashing problems efficiently and confidently.
