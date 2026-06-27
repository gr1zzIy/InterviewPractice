namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Перевірити, чи містить масив задане число.
/// </summary>
public static class T006_ContainsNumber
{
    private const string TASK_NUMBER = "006";

    public static void Run(int[] numbers, int target)
    {
        int[] array = (int[])numbers.Clone();
        
        // Console.WriteLine($"{TASK_NUMBER} - The array contains the number: {array.Contains(target)}");

        foreach (var t in array)
        {
            if (t == target)
            {
                Console.WriteLine($"{TASK_NUMBER} - The array contains the number: {t}");
                return;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The array does not contain the number: {target}");
    }
}