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
        int length = numbers.Length;

        int[] sortedNumbers = BubbleSort(numbers, length);
        
        int secondLargest = sortedNumbers[length - 2];
        
        Console.WriteLine($"{TASK_NUMBER} - The second largest element is: {secondLargest}");
    }
    
    private static int[] BubbleSort(int[] numbers, int length)
    {
        int temp;
        bool swapped = true;

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                swapped = false;
                
                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
        
        return numbers;
    }
}