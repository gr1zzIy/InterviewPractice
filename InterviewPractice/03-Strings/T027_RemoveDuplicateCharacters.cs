namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 027 — Remove Duplicate Characters
/// Умова
/// Прибрати дублікати символів, залишивши лише першу появу.
/// </summary>
public class T027_RemoveDuplicateCharacters
{
    private const string TASK_NUMBER = "027";
    
    public static void Run(string input)
    {
        string result = "";

        foreach (var c in input)
        {
            if (!result.Contains(c))
            {
                result += c;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The string without duplicate characters is: {result}");
    }
}