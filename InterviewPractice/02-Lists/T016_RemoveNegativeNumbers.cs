namespace InterviewPractice._02_Lists;

/// <summary>
/// Задача 016 — Remove Negative Numbers
/// Умова
/// Дано список цілих чисел.
/// Необхідно видалити всі від'ємні числа зі списку.
/// Не створювати новий список.
/// </summary>
public class T016_RemoveNegativeNumbers
{
    private const string TASK_NUMBER = "016";

    public static void Run(List<int> nums)
    {
        var resultStr = $"{string.Join(", ", nums.Where(x => x >= 0).ToList())}";
        
        Console.WriteLine($"{TASK_NUMBER} - {resultStr}");
    }
}