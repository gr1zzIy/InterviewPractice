using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 036 — Group Words By First Letter
/// Умова
/// Згрупувати слова за першою літерою.
/// </summary>
public class T036_GroupWordsByFirstLetter
{
    private const string TASK_NUMBER = "036";

    public static void Run(string input)
    {
        var dictionary = new Dictionary<string, string>();
        var result = new StringBuilder();
        string firstLetter = string.Empty;
        
        var cleanedWords = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.Trim().ToLower())
            .Where(word => !string.IsNullOrWhiteSpace(word));

        foreach (var word in cleanedWords)
        {
            firstLetter = word.Substring(0, 1);

            if (!dictionary.TryAdd(firstLetter, $"{word} "))
            {
                if (dictionary[firstLetter].Contains(word))
                    continue;
                
                dictionary[firstLetter] += $"{word} ";
            }
        }

        foreach (var record in dictionary)
        {
            result.AppendLine($"{record.Key} -> {record.Value}");
        }
        
        Console.WriteLine($"{TASK_NUMBER} - [{input}] Group Words By First Letter:\n{result}");
    }
}