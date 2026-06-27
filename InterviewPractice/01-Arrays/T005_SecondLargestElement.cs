using InterviewPractice._09_Algorithms;

namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Знайти другий найбільший елемент масиву.
/// </summary>
public static class T005_SecondLargestElement
{
    private const string TASK_NUMBER = "005";

    public static void Run(int[] numbers)
    {
        int[] array = (int[])numbers.Clone();
        int length = array.Length;

        int[] sortedNumbers = BubbleSort.Execute(array, length);
        
        int secondLargest = sortedNumbers[length - 2];
        
        Console.WriteLine($"{TASK_NUMBER} - The second largest element is: {secondLargest}");
    }
}