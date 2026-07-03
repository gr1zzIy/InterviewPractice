using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 031 — Word Frequency
/// Умова
/// Є речення.
/// Порахувати кількість входжень кожного слова.
/// Регістр не враховувати.
/// </summary>
public class T031_WordFrequency
{
    private const string TASK_NUMBER = "031";

    public static void Run(string input)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        string[] words = input.ToLowerInvariant().Split(' ');
        StringBuilder result = new StringBuilder();
        
        foreach (string word in words)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word]++;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }

        foreach (var record in dictionary)
        {
            result.AppendLine($"\t{record.Key} -> {record.Value}");
        }
        
        Console.WriteLine($"{TASK_NUMBER} - [{input}] Results:\n{result}");
    }
}