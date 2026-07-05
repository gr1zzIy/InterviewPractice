namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T043_RansomNote.cs ⭐⭐⭐
/// Умова
/// Є два рядки.
/// Чи можна скласти перший рядок із символів другого?
/// Кожен символ можна використати лише один раз.
/// </summary>
public class T043_RansomNote
{
    private const string TASK_NUMBER = "043";

    public static void Run(List<string> words)
    {
        string first = words[0];
        string second = words[1];

        if (first.Length > second.Length)
        {
            Console.WriteLine($"{TASK_NUMBER} - False");
            return;
        }
        
        if (CanRansom(first, second))
        {
            Console.WriteLine($"{TASK_NUMBER} - True");
        }
        else
        {
            Console.WriteLine($"{TASK_NUMBER} - False");
        }
    }

    private static bool CanRansom(string w1, string w2)
    {
        var charCountSecond = new Dictionary<char, int>();

        foreach (var c in w2)
        {
            if (!charCountSecond.TryAdd(c, 1))
            {
                charCountSecond[c]++;
            }
        }

        foreach (var c in w1)
        {
            if (charCountSecond.TryGetValue(c, out var count) && count > 0)
            {
                charCountSecond[c]--;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}