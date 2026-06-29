namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 023 — Longest Word
/// Умова
/// Знайти найдовше слово у реченні.
/// Якщо їх декілька — повернути перше.
/// </summary>
public class T023_LongestWord
{
    private const string TASK_NUMBER = "023";
    
    public static void Run(string input)
    {
        string[] words = input.Split(' ');
        string longestWord = words[0];
        int longestWordLength = words[0].Length;

        foreach (var word in words)
        {
            if (word.Length > longestWordLength)
            {
                longestWord = word;
                longestWordLength = word.Length;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The longest word is: {longestWord}");
    }
}