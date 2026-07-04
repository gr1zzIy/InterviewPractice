using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 040 — Count Numbers
/// Умова
/// Є список чисел.
/// Порахувати кількість кожного числа.
/// </summary>
public class T040_CountNumbers
{
    private const string TASK_NUMBER = "040";

    public static void Run(int[] numbers)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        var result = new StringBuilder();
        string originalNums = string.Join(", ", numbers);
        
        foreach (var number in numbers)
        {
            if (counts.TryGetValue(number, out int count))
            {
                counts[number] = count + 1;
            }
            else
            {
                counts.Add(number, 1);
            }
        }

        foreach (var record in counts)
        {
            result.AppendLine($"\t{record.Key} -> {record.Value}");
        }
        
        Console.WriteLine($"{TASK_NUMBER} - [{originalNums}] Result:\n{result}");
    }
}