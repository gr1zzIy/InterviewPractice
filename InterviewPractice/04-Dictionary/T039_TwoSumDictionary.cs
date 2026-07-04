namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Задача 039 — Two Sum (Dictionary)
/// Пам'ятаєш, ми робили її на масивах.
/// Тепер реалізуй оптимальне рішення через Dictionary за O(n).
/// </summary>
public class T039_TwoSumDictionary
{
    private const string TASK_NUMBER = "039";

    public static void Run(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        string originalNums = string.Join(", ", nums);
        
        for (int i = 0; i < nums.Length; i++)
        {
            int necessary = target - nums[i];
            
            if (numToIndex.TryGetValue(necessary, out int index))
            {
                Console.WriteLine($"{TASK_NUMBER} - [{originalNums}] Result: [{index}, {i}]");
                return;
            }

            // numToIndex.Add(nums[i], i); - кидає помилку
            numToIndex[nums[i]] = i; // краще перезаписати якщо є 
        }

        Console.WriteLine($"{TASK_NUMBER} - [{originalNums}] No two sum solution found.");
    }
}