using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Умова
/// Є список слів.
/// Необхідно згрупувати анаграми.
/// Анаграми — слова, які складаються з однакових букв.
/// </summary>
public class T041_GroupAnagrams
{
    private const string TASK_NUMBER = "041";

    public static void Run(List<string> words)
    {
        var dictionary = new Dictionary<string, List<string>>();
        var result = new StringBuilder();

        foreach (var word in words)
        {
            var sortedWord = new string(word.ToCharArray().OrderBy(c => c).ToArray());

            if (dictionary.ContainsKey(sortedWord))
            {
                dictionary[sortedWord].Add($"{word }");
            }
            else
            {
                dictionary.Add(sortedWord, new List<string> { $"{word }" });
            }
        }

        foreach (var record in dictionary)
        {
            result.AppendLine($"\t[{string.Join(", ", record.Value)}]");
        }
        
        Console.WriteLine($"{TASK_NUMBER}: Group Anagrams\nInput: [{string.Join(", ", words)}]\nOutput:\n{result}");
    }
}