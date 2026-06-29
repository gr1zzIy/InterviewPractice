namespace InterviewPractice._03_Strings;

public class T021_CountVowels
{
    private const string TASK_NUMBER = "021";
    
    public static void Run(string input)
    {
        int vowelsCount = 0;
        string vowels = "aeiou";
        string inputLower = input.ToLower();
        
        foreach (var c in inputLower)
        {
            if (vowels.Contains(c))
            {
                vowelsCount++;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The count of vowels is: {vowelsCount}");
    }
}