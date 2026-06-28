namespace InterviewPractice._02_Lists;

/// <summary>
/// Задача 017 — Insert Number
/// Умова
/// Є список чисел.
/// Потрібно вставити задане число у вказаний індекс.
/// </summary>
public class T017_InsertNumber
{
    private const string TASK_NUMBER = "017";

    public static void Run(List<int> nums, int valueToInsert, int requiredIndex)
    {
        nums.Insert(requiredIndex, valueToInsert);
        
        var resultStr = string.Join(", ", nums);
        
        Console.WriteLine($"{TASK_NUMBER} - {resultStr}");
    }
}