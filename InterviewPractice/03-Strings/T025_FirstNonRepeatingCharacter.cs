namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 025 — First Non-Repeating Character
/// Умова
/// Знайти перший символ, який зустрічається лише один раз.
/// Поки що без Dictionary.
/// </summary>
public class T025_FirstNonRepeatingCharacter
{
    private const string TASK_NUMBER = "025";

    public static void Run(string input)
    {
        char nonRepeatingCharacters = char.MinValue;
        
        foreach (var item in input)
        {
            int currentIndex = input.IndexOf(item);
            int lastIndex = input.LastIndexOf(item);
            
            if (currentIndex == lastIndex)
            {
                nonRepeatingCharacters = item;
                break;
            }
        }

        if (nonRepeatingCharacters == char.MinValue)
        {
            Console.WriteLine($"{TASK_NUMBER} - немає символу");
        }
        else
        {
            Console.WriteLine($"{TASK_NUMBER} - The first non-repeating character is: {nonRepeatingCharacters}");
        }
    }
}