namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 028 — Count Digits
/// Умова
/// Порахувати кількість цифр у рядку.
/// </summary>
public class T028_CountDigits
{
    private const string TASK_NUMBER = "028";
    
    public static void Run(string input)
    {
        int digitCount = 0;

        foreach (var c in input)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The number of digits is: {digitCount}");
    }
}