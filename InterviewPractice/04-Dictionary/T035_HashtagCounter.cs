using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 035 — Hashtag Counter
/// Умова
/// Є список речень.
/// Порахувати всі хештеги. Записувати хештег без '#' знаку 
/// Вивести у порядку спадання кількості.
/// </summary>
public class T035_HashtagCounter
{
    private const string TASK_NUMBER = "035";

    public static void Run(List<string> sentences)
    {
        Dictionary<string, int> hashtagCounter = new Dictionary<string, int>();
        var result = new StringBuilder();
        
        foreach (string sentence in sentences)
        {
            foreach (var word in sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (word.StartsWith("#"))
                {
                    string withoutHashtag = word.Substring(1);
                    
                    if (!hashtagCounter.TryAdd(withoutHashtag, 1))
                    {
                        hashtagCounter[withoutHashtag]++;
                    }
                }
            }
        }

        foreach (var record in hashtagCounter.OrderByDescending(x => x.Value))
        {
            result.AppendLine($"\t{record.Key} -> {record.Value}");
        }
        
        Console.WriteLine($"{TASK_NUMBER} - Hashtag Counter:\n{result}");
    }
}