using InterviewPractice._06_Sorting;
using InterviewPractice._09_Algorithms;

namespace InterviewPractice._01_Arrays;

/// <summary>
/// ЗАДАЧА 010 — Find Missing Number
/// Умова
/// Є масив з чисел від 1..N, але одне число пропущене.
/// Знайти його.
/// </summary>
public class T010_FindMissingNumber
{
    private const string TASK_NUMBER = "010";

    public static void Run(int[] numbers)
    {
        int[] array = (int[])numbers.Clone();
        int length = array.Length;
        
        int[] sortedArray = T061_BubbleSortAndSelectionSort.BubbleSort(array);
        
        int endSequence = sortedArray[length - 1];

        for (int startSequence = sortedArray[0]; startSequence < endSequence; startSequence++)
        {
            if (!array.Contains(startSequence))
            {
                Console.WriteLine($"{TASK_NUMBER} - The missing number is: {startSequence}");
                return;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The missing number is not found.");
    }
}