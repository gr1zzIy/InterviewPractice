using InterviewPractice._01_Arrays;

namespace InterviewPractice;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayTasks();
        
        Console.WriteLine(@"
--------------------
All for improvement!");
    }

    private static void ArrayTasks()
    {
        int[] numbers = [7, 2, 15, 0, 4, 10, 11, 10, 0, 8, 2];
        int[] missingOneNumber = [2, 5, 3, 1, 6, 7];
        int target = 15;
        
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
    }
}