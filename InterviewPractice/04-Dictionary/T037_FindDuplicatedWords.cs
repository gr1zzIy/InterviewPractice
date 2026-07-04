using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 037 — Find Duplicated Words
/// Умова
/// Повернути лише ті слова, які зустрічаються більше одного разу.
/// </summary>
public class T037_FindDuplicatedWords
{
    private const string TASK_NUMBER = "037";

    public static void Run(string input)
    {
        var dictionary = new Dictionary<string, int>();
        var result = new StringBuilder();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

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

        foreach (var item in dictionary)
        {
            if (item.Value > 1)
            {
                result.AppendLine($"\t{item.Key}");
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - [{input}] Find Duplicated Words:\n{result}");
    }
}