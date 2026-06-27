namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Порахувати суму всіх елементів масиву.
/// </summary>
public static class T003_SumOfArray
{
    private const string TASK_NUMBER = "003";

    public static void Run(int[] numbers)
    {
        int[] array = (int[])numbers.Clone();
        
        // Console.WriteLine($"{TASK_NUMBER} - The sum of the array is: {array.Sum()}");
        
        int sum = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The sum of the array is: {sum}");
    }
}