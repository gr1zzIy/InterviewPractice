namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Знайти найменший елемент масиву.
/// </summary>
public class T002_FindMinimum
{
    private const string TASK_NUMBER = "002";
    
    public static void Run(int[] numbers)
    {
        int length = numbers.Length;

        // Console.WriteLine($"{TASK_NUMBER} - The minimum number in the array is: {numbers.Min()}");
        
        int min = numbers[0];

        for (int i = 0; i < length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The minimum number in the array is: {min}");
    }
}