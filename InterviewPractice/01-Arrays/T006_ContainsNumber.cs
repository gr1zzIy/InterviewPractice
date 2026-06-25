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
        // Console.WriteLine($"{TASK_NUMBER} - The array contains the number: {numbers.Contains(target)}");

        foreach (int number in numbers)
        {
            if (number == target)
            {
                Console.WriteLine($"{TASK_NUMBER} - The array contains the number: {number}");
                return;
            }
        }
    }
}