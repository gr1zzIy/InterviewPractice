namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 030 — Most Frequent Character
/// Умова
/// Знайти символ, який зустрічається найчастіше.
/// Якщо декілька — повернути той, який зустрівся першим.
/// Тут вже дозволяється використовувати Dictionary. Це буде плавний перехід до наступного блоку.
/// </summary>
public class T030_MostFrequentCharacter
{
    private const string TASK_NUMBER = "030";
    
    public static void Run(string input)
    {
        string mostFrequentChar = string.Empty;
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                if (dict.ContainsKey(c.ToString()))
                {
                    dict[c.ToString()]++;
                }
                else
                {
                    dict.Add(c.ToString(), 1);
                }
            }
        }
        
        mostFrequentChar = dict.OrderByDescending(x => x.Value).First().Key;
        
        Console.WriteLine($"{TASK_NUMBER} - The most frequent character is: {mostFrequentChar}");
    }
}