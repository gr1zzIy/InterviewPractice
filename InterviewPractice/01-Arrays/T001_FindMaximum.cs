namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Знайти найбільший елемент.
/// </summary>
public static class T001_FindMaximum
{
    private const string TASK_NUMBER = "001";
    
    public static void Run(int[] numbers)
    {
        int[] array = (int[])numbers.Clone();
        int max = array[0];
        
        // Console.WriteLine($"{TASK_NUMBER} - The maximum number is: {array.Max()}");

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The maximum number is: {max}");
    }
}