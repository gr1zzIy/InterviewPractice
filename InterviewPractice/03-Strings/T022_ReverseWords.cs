namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 022 — Reverse Words
/// Умова
/// Є речення.
/// Потрібно розвернути порядок слів, а не символів.
/// </summary>
public class T022_ReverseWords
{
    private const string TASK_NUMBER = "022";

    public static void Run(string input)
    {
        string result = "";
        
        string[] words = input.Split(' ');
        
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i] + " ";
        }
        
        Console.WriteLine($"{TASK_NUMBER} - {result}");
    }
}