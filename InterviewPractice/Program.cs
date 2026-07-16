using InterviewPractice._01_Arrays;
using InterviewPractice._02_Lists;
using InterviewPractice._03_Strings;
using InterviewPractice._04_Dictionary;
using InterviewPractice._05_HashSet;
using InterviewPractice._06_Sorting;
using InterviewPractice._07_Queue___08_Stack;

namespace InterviewPractice;

public class Program
{
    public static void Main(string[] args)
    {
        // ArrayTasks();
        // ListTasks();
        // StringTasks();
        // DictionaryTasks();
        // HashSetTasks();
        // SortingTasks();
        QueueAndStackTasks();
        
        Console.WriteLine(@"
--------------------
All for improvement!");
    }

    private static void ArrayTasks()
    {
        int[] numbers = [7, 2, 15, 0, 4, 10, 11, 10, 0, 8, 2];
        int[] missingOneNumber = [2, 5, 3, 1, 6, 7];
        int[] prices = [7,1,5,3,6,4]; // expected max profit = 5
        int[] prices2 = [7,6,4,3,1]; // expected max profit = 0
        int target = 15;

        // merged = [1, 1, 2, 3, 4, 4]
        int[] nums1 = [1, 2, 4];
        int[] nums2 = [1, 3, 4]; 
        
        T001_FindMaximum.Run(numbers);
        T002_FindMinimum.Run(numbers);
        T003_SumOfArray.Run(numbers);
        T004_AverageValue.Run(numbers);
        T005_SecondLargestElement.Run(numbers);
        T006_ContainsNumber.Run(numbers, target);
        T007_CountEvenNumbers.Run(numbers);
        T008_MoveZerosToEnd.Run(numbers);
        T009_RemoveDuplicatesUnsorted.Run(numbers);
        T010_FindMissingNumber.Run(missingOneNumber);
        T011_TwoSum.Run(numbers, target);
        T012_MaxProfit.Run(prices);
        T013_MergeTwoSortedArrays.Run(nums1, nums2);
    }

    private static void ListTasks()
    {
        T016_RemoveNegativeNumbers.Run(new List<int> { 1, -2, 3, -4, 5 }); // [1, 3, 5]
        T017_InsertNumber.Run(new List<int> { 1, 2, 3, 4, 5 }, 99, 2); // [1, 2, 99, 3, 4, 5]
        T018_RemoveRange.Run(new List<int> { 1, 2, 3, 4, 5 }, 1, 3); // [1, 5]
        T019_MergeLists.Run(new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }); // [1, 2, 3, 4, 5, 6]
        T020_RemoveDuplicatesFromList.Run(new List<int> { 5, 3, 5, 2, 3, 1 }); // [5, 3, 2, 1]
    }
    
    private static void StringTasks()
    {
        T021_CountVowels.Run("Hello World"); // 3
        T022_ReverseWords.Run("I love C#"); // C# love I
        T023_LongestWord.Run("I love programming in CSharp"); // programming
        T024_WordCounter.Run("I   love     C#"); // 3
        T025_FirstNonRepeatingCharacter.Run("aabbcdde"); // c
        T026_CompressString.Run("aaabbcccc"); // a3b2c4
        T027_RemoveDuplicateCharacters.Run("programming"); // progamin
        T028_CountDigits.Run("abc123de45"); // 5
        T029_IsSentencePalindrome.Run("A man a plan a canal Panama"); // true
        T030_MostFrequentCharacter.Run("programming"); // r
    }

    private static void DictionaryTasks()
    {
        // Part 1
        Console.WriteLine("Part 1:\n");
        
        T031_WordFrequency.Run("I love programming and i love C#"); // I - 2, love - 2, programming - 1, and - 1, C# - 1
        T032_CharacterFrequency.Run("banana"); // b - 1, a - 3, n - 2
        T033_MostFrequentWord.Run("cat dog cat bird dog cat"); // cat
        T034_Top3FrequentWords.Run("apple banana apple orange banana apple grape"); // apple - 3, banana - 2, orange - 1
        T035_HashtagCounter.Run(new List<string>
        {
            "I love #programming", 
            "#CSharp is great", 
            "I love #CSharp and #programming",
            "#java hi",
            "I wanna job in ONSEO #onseo"
        });
        T036_GroupWordsByFirstLetter.Run("apple banana apricot cherry date elderberry fig grape"); 
        T037_FindDuplicatedWords.Run("cat dog cat bird dog cat"); // cat dog
        T038_FirstUniqueWord.Run("apple banana apple orange banana apple grape"); // orange
        T039_TwoSumDictionary.Run(new int[] { 2, 7, 11, 15 }, 9); // [0, 1]
        T040_CountNumbers.Run(new int[] { 1, 2, 2, 3, 3, 3, 4 }); // 1 - 1, 2 - 2, 3 - 3, 4 - 1
        
        // Part 2
        Console.WriteLine("\nPart 2:\n");
        
        T041_GroupAnagrams.Run(new List<string> { "eat", "tea", "tan", "ate", "nat", "bat" }); // [eat, tea, ate], [tan, nat], [bat]
        T042_IsomorphicStrings.Run(new List<string> { "egg", "add" }); // True
        T043_RansomNote.Run(new List<string> { "hello", "olehhl" }); // True
        T044_IntersectionOfArrays.Run(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }); // [2]
        T045_UniqueEmails.Run(new List<string>
        {
            "test.email+spam@gmail.com",
            "testemail@gmail.com",
            "test.email+abc@gmail.com",
        }); // 1
        T046_FindPairWithSum.Run(new int[] { 10, 15, 3, 7 }, 17); // True
        T047_InvertDictionary.Run(new Dictionary<string, string>
        {
            { "UA", "Ukraine" },
            { "PL", "Poland"},
            { "DE", "Germany"}
        }); // Ukraine : UA, Poland : PL, Germany : DE
        T048_CountPairs.Run(new int[] { 1, 1, 2, 2, 2, 3 }); // Count pairs: 2
        T049_MostFrequentNumber.Run(new int[] { 1, 2, 2, 3, 3, 3, 4 }); // Most frequent number: 3
        T050_MiniInterviewHashtags.Run(new List<string>
        {
            "I love #dotnet #csharp",
            "#dotnet is awesome",
            "#csharp #dotnet",
            "#sql #dotnet",
            "#csharp #sql",
            "#git"
        });
    }
    
    private static void HashSetTasks()
    {
        T051_RemoveDuplicates.Run(new int[] { 1, 2, 3, 2, 1, 4, 5 }); // [1, 2, 3, 4, 5]
        T052_FindFirstDuplicate.Run(new int[] { 1, 2, 3, 2, 1, 4, 5 }); // First duplicate: 2
        T053_ContainsDuplicates.Run(new int[] { 1, 2, 3 }); // false
        T054_CommonElements.Run(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 5, 6 }); // [3, 4]
        T055_MissingNumbers.Run(new int[] { 1, 2, 4, 6 }, 6); // [3, 5]
        T056_LongestConsecutiveSequence.Run(new int[] { 100, 4, 200, 1, 3, 2 }); // The longest consecutive sequence is: 4
        T057_DifferenceBetweenArrays.Run(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 5 }); // [1, 2]
        T058_SymmetricDifference.Run(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 5 }); // [1, 2, 5]
        T059_UniqueWords.Run(new List<string>
        {
            "I love programming",
            "Programming is fun",
            "I love C#"
        }); // Unique words: 6
        T060_UniqueVisitors.Run(new List<int> { 1, 2, 3, 2, 1, 4, 5 }); // Unique visitors: 5
    }
    
    private static void SortingTasks()
    {
        int[] numbers = { 5, 2, 9, 1, 5 };
        int[] sortedNumbersBubble = T061_BubbleSortAndSelectionSort.BubbleSort((int[])numbers.Clone());
        int[] sortedNumbersSelection = T061_BubbleSortAndSelectionSort.SelectionSort((int[])numbers.Clone());

        Console.WriteLine($"061/1 - Bubble Sort Result: [{string.Join(", ", sortedNumbersBubble)}]");
        Console.WriteLine($"061/2 - Selection Sort Result: [{string.Join(", ", sortedNumbersSelection)}]");
        
        T062_MergeIntervals.Run(new int[][] { new[] {8,10}, new[] {1,3}, new[] {2,6}, new[] {15,18} });
        T062_MergeIntervals.Run(new int[][] { new[] {2,3}, new[] {4,5}, new[] {6,7}, new[] {8,9}, new[] {1,10} });
        
        T063_CustomObjectSorting.Run(new List<Employee>
        {
            new Employee("Alice", 70000),
            new Employee("Bob", 50000),
            new Employee("Charlie", 60000),
            new Employee("David", 80000)
        });
        
        T064_KthLargestElement.Run(new int[] { 3, 2, 1, 5, 6, 4 }, 2); // Expected output: 5
        T065_SortColors.Run(new int[] { 2, 0, 2, 1, 1, 0 }); // Expected output: [0, 0, 1, 1, 2, 2]
    }
    
    private static void QueueAndStackTasks()
    {
        T066_ValidParentheses.Run("()[]{}"); // true
        T067_MinStack.Run(); // MinStack operations
        T068_EvaluateReversePolishNotation.Run(new string[] { "2", "1", "+", "3", "*" }); // 9
    }
}