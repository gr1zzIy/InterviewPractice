namespace InterviewPractice._05_HashSet;

/// <summary>
/// T056_LongestConsecutiveSequence.cs ⭐⭐⭐
/// Перша задача рівня Medium.
/// Умова
/// Знайти довжину найдовшої послідовності сусідніх чисел.
/// </summary>
public class T056_LongestConsecutiveSequence
{
    private const string TASK_NUMBER = "056";
    
    public static void Run(int[] numbers)
    {
        HashSet<int> numberSet = new HashSet<int>(numbers);
        int longestStreak = 0;
        string originalNumbersString = string.Join(", ", numbers);
        
        foreach (var number in numberSet)
        {
            if (!numberSet.Contains(number - 1))
            {
                var currentNumber = number;
                var currentStreak = 1;

                while (numberSet.Contains(currentNumber + 1))
                {
                    currentNumber++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - [{originalNumbersString}] => The longest consecutive sequence is: {longestStreak}");
    }
}