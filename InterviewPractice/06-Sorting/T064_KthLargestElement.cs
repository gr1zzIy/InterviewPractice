namespace InterviewPractice._06_Sorting;

/// <summary>
/// T064_KthLargestElement.cs
/// Умова: Знайти k-й за величиною елемент у невідсортованому масиві.
/// (Примітка: це має бути k-й елемент у відсортованому порядку,
/// а не просто k-й унікальний).
/// Вхід: Масив [3, 2, 1, 5, 6, 4], k = 2
/// Результат: Число 5 (бо якщо відсортувати: 1, 2, 3, 4, 5, 6, то другий з кінця — 5).
/// </summary>
public class T064_KthLargestElement
{
    private const string TASK_NUMBER = "064";

    public static void Run(int[] numbers, int k)
    {
        if (numbers.Length < 2)
        {
            Console.WriteLine($"{TASK_NUMBER} - Array is too small to find the k-th largest element.");
            return;
        }
        
        numbers = BubbleSortDescending(numbers);
        int kthLargest = numbers[k - 1];
        Console.WriteLine($"{TASK_NUMBER} - The k-th largest element is: {kthLargest}");
    }

    private static int[] BubbleSortDescending(int[] numbers)
    {
        int length = numbers.Length;
        bool swapped = false;

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - 1 - i; j++)
            {
                if (numbers[j] < numbers[j + 1])
                {
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    swapped = true;
                }
            }
            
            if (!swapped)
                break;
        }
        
        return numbers;
    }
}