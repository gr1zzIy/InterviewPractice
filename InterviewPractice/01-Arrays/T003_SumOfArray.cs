namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Порахувати суму всіх елементів масиву.
/// </summary>
public class T003_SumOfArray
{
    private const string TASK_NUMBER = "003";

    public static void Run(int[] numbers)
    {
        // Console.WriteLine($"{TASK_NUMBER} - The sum of the array is: {numbers.Sum()}");
        
        int sum = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The sum of the array is: {sum}");
    }
}