namespace InterviewPractice._05_HashSet;

/// <summary>
/// T055_MissingNumbers.cs ⭐⭐
/// Умова
/// Є числа від 1 до N.
/// Деякі відсутні.
/// Повернути всі відсутні.
/// </summary>
public class T055_MissingNumbers
{
    private const string TASK_NUMBER = "055";

    public static void Run(int[] numbers, int maxNumber)
    {
        HashSet<int> numberSet = new HashSet<int>(numbers);
        List<int> missingNumbers = new List<int>();

        for (int i = 1; i < maxNumber; i++)
        {
            if (!numberSet.Contains(i))
            {
                missingNumbers.Add(i);
            }
        }
        
        string originalNumbersString = string.Join(", ", numbers);
        string missingNumbersString = string.Join(", ", missingNumbers);
        
        Console.WriteLine($"{TASK_NUMBER} -   Original numbers: [{originalNumbersString}],\n\tMax number: {maxNumber} \n\t\t=> Missing numbers: [{missingNumbersString}]");
    }
}