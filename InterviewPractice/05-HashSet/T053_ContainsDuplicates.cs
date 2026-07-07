namespace InterviewPractice._05_HashSet;

/// <summary>
/// T053_ContainsDuplicates.cs ⭐
/// Умова
/// Перевірити, чи містить список дублікати.
/// </summary>
public class T053_ContainsDuplicates
{
    private const string TASK_NUMBER = "053";

    public static void Run(int[] numbers)
    {
        HashSet<int> dublicates = new HashSet<int>();
        string original = string.Join(", ", numbers);
        
        foreach (var number in numbers)
        {
            if (!dublicates.Add(number))
            {
                Console.WriteLine($"{TASK_NUMBER} - Original: [{original}] => Contains duplicates: true");
                return;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - Original: [{original}] => Contains duplicates: false");
    }
}