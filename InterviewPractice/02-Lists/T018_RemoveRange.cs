namespace InterviewPractice._02_Lists;

/// <summary>
/// Задача 018 — Remove Range
/// Умова
/// Є список.
/// Потрібно видалити N елементів, починаючи із заданого індексу.
/// </summary>
public class T018_RemoveRange
{
    private const string TASK_NUMBER = "018";

    public static void Run(List<int> nums, int startIndex, int count)
    {
        //nums.RemoveRange(startIndex, count);
        
        if (startIndex < 0 || startIndex >= nums.Count)
            return;
        
        while (count > 0)
        {
            nums.RemoveAt(startIndex);
            count--;
        }
        
        Console.WriteLine($"{TASK_NUMBER} - {string.Join(", ", nums)}");
    }
}