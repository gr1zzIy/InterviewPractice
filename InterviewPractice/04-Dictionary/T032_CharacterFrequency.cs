using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 032 — Character Frequency
/// Умова
/// Порахувати кількість входжень кожного символу.
/// Пробіли не рахувати.
/// </summary>
public class T032_CharacterFrequency
{
    private const string TASK_NUMBER = "032";

    public static void Run(string input)
    {
        var dictionary = new Dictionary<string, int>();
        var result = new StringBuilder();
        var withoutSpaces = input.Replace(" ", "");
        
        foreach (var c in withoutSpaces)
        {
            if (!dictionary.TryAdd(c.ToString(), 1))
            {
                dictionary[c.ToString()]++;
            }
        }

        foreach (var record in dictionary)
        {
            result.AppendLine($"\t{record.Key} -> {record.Value}");
        }
        
        Console.WriteLine($"{TASK_NUMBER} - [{input}] Results:\n{result}");
    }
}