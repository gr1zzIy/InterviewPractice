namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 026 — Compress String
/// Умова
/// Стиснути рядок.
/// Наприклад
/// aaabbcccc
/// ↓
/// a3b2c4
/// </summary>
public class T026_CompressString
{
    private const string TASK_NUMBER = "026";
    
    public static void Run(string input)
    {
        string original = input;
        int count = 1;
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            while (input.IndexOf(input[i]) != input.LastIndexOf(input[i]))
            {
                count++;
                input = input.Remove(input.LastIndexOf(input[i]), 1);
            }
            
            result += $"{input[i]}{count}";
            count = 1;
        }
        
        Console.WriteLine($"{TASK_NUMBER} - \n\tThe original is: {original}\n\tThe compressed string is: {result}");
    }
}