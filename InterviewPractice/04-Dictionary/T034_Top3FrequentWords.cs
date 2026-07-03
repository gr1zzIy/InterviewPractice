using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 034 — Top 3 Frequent Words
/// Умова
/// Повернути три найчастіші слова.
///  Відсортувати за спаданням.
/// </summary>
public class T034_Top3FrequentWords
{
    private const string TASK_NUMBER = "034";

    public static void Run(string input, int selectTopN = 3)
    {
        var dictionary = new Dictionary<string, int>();
        var result = new StringBuilder();
        string[] words = input.ToLowerInvariant().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;
        
        foreach (var word in words)
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
        
        foreach (var record in dictionary.OrderByDescending(x => x.Value))
        {
            if (counter == selectTopN)
            {
                break;
            }
            
            result.AppendLine($"\t{record.Key} -> {record.Value}");
            counter++;
        }
        
        Console.WriteLine($"{TASK_NUMBER} - [{input}] Top {selectTopN} Frequent Words:\n{result}");
    }
}