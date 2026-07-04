namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 038 — First Unique Word
/// Умова
/// Знайти перше слово, яке зустрічається лише один раз.
/// </summary>
public class T038_FirstUniqueWord
{
    private const string TASK_NUMBER = "038";

    public static void Run(string input)
    {
        var uniq = new Dictionary<string, int>();
        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (!uniq.ContainsKey(word))
            {
                uniq.Add(word, 1);
            }
            else
            {
                uniq[word]++;
            }
        }

        string result = uniq.Where(x=>x.Value == 1)
            .Select(x => x.Key)
            .FirstOrDefault() ?? "No unique words found";
        
        Console.WriteLine($"{TASK_NUMBER} - [{input}] First Unique Word: {result}");
    }
}