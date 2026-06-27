namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Знайти найменший елемент масиву.
/// </summary>
public static class T002_FindMinimum
{
    private const string TASK_NUMBER = "002";
    
    public static void Run(int[] numbers)
    {
        int[] array = (int[])numbers.Clone();
        int length = array.Length;

        // Console.WriteLine($"{TASK_NUMBER} - The minimum number in the array is: {array.Min()}");
        
        int min = array[0];

        for (int i = 0; i < length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The minimum number in the array is: {min}");
    }
}