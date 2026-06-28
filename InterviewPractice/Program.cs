using InterviewPractice._01_Arrays;
using InterviewPractice._02_Lists;

namespace InterviewPractice;

public class Program
{
    public static void Main(string[] args)
    {
        // ArrayTasks();
        ListTasks();
        
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
        T016_RemoveNegativeNumbers.Run(new List<int> { 1, -2, 3, -4, 5 });
        T017_InsertNumber.Run(new List<int> { 1, 2, 3, 4, 5 }, 99, 2);
        T018_RemoveRange.Run(new List<int> { 1, 2, 3, 4, 5 }, 1, 3);
        T019_MergeLists.Run(new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 });
    }
}