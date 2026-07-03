namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 033 — Most Frequent Word
/// Умова
/// Знайти слово, яке зустрічається найчастіше.
/// Якщо декілька — повернути перше.
/// </summary>
public class T033_MostFrequentWord
{
    private const string TASK_NUMBER = "033";

    public static void Run(string input)
    {
        var dictionary = new Dictionary<string, int>();
        string result = string.Empty;
        string[] words = input.ToLowerInvariant().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var word in words)
        {
            if (dictionary.TryGetValue(word, out var count))
            {
                dictionary[word] = count + 1;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }
        
        result = dictionary
            .OrderByDescending(kvp => kvp.Value)
            .FirstOrDefault().Key;
        
        Console.WriteLine($"{TASK_NUMBER} - [{input}] Most Frequent Word:\n\t{result}");
    }
}