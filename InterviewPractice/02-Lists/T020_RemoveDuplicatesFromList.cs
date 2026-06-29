namespace InterviewPractice._02_Lists;

/// <summary>
/// Задача 020 — Remove Duplicates From List
/// Умова
/// Є список чисел.
/// Потрібно прибрати дублікати, зберігши порядок першої появи елемента.
/// </summary>
public class T020_RemoveDuplicatesFromList
{
    private const string TASK_NUMBER = "020";
    
    public static void Run(List<int> nums)
    {
        List<int> result = new List<int>();

        foreach (var num in nums)
        {
            if (!result.Contains(num))
                result.Add(num);
        }
        
        string originalString = string.Join(", ", nums);
        string resultString = string.Join(", ", result);
        
        Console.WriteLine($"{TASK_NUMBER} - Original: [{originalString}] => Without Duplicates: [{resultString}]");
    }
}