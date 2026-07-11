namespace InterviewPractice._06_Sorting;

/// <summary>
/// T065_SortColors.cs
/// Умова: Алгоритм триколірного прапора (Dijkstra's Dutch National Flag).
/// Дано масив, що містить лише 0, 1 та 2.
/// Відсортувати його in-place (без виділення нової пам'яті)
/// за один прохід по масиву (O(N) часу, O(1) пам'яті).
/// Вхід: int[] { 2, 0, 2, 1, 1, 0 }
/// Результат: Модифікований масив [0, 0, 1, 1, 2, 2].
/// </summary>
public class T065_SortColors
{
    private const string TASK_NUMBER = "065";
    
    public static void Run(int[] nums)
    {
        int lo = 0;
        int mid = 0;
        int hi = nums.Length - 1;

        while (mid <= hi)
        {
            if (nums[mid] == 0)
            {
                (nums[lo], nums[mid]) = (nums[mid], nums[lo]);
                lo++;
                mid++;
            }
            else if (nums[mid] == 1)
            {
                mid++;
            }
            else
            {
                (nums[mid], nums[hi]) = (nums[hi], nums[mid]);
                hi--;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - Sorted colors: [{string.Join(", ", nums)}]");
    }
}