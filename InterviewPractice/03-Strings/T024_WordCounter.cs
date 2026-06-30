namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 024 — Word Counter
/// Умова
/// Порахувати кількість слів у реченні.
/// Декілька пробілів підряд потрібно ігнорувати.
/// </summary>
public class T024_WordCounter
{
    private const string TASK_NUMBER = "024";

    public static void Run(string input)
    {
        int wordCounter = 0;
        
        foreach (var c in input.Split(' '))
        {
            if (!string.IsNullOrEmpty(c.Trim()))
            {
                wordCounter++;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The number of words is: {wordCounter}");
    }
}