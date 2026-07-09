namespace InterviewPractice._06_Sorting;

/// <summary>
/// T062_MergeIntervals.cs
/// Умова: Дано масив інтервалів (масив масивів з двох чисел: старт і кінець).
/// Необхідно об'єднати всі інтервали, що перекриваються.
/// Спочатку масив треба відсортувати за стартовим часом.
/// Вхід: int[][] { new[] {1,3}, new[] {2,6}, new[] {8,10}, new[] {15,18} }
/// Результат: Масив масивів [[1,6], [8,10], [15,18]] (інтервали [1,3] та [2,6] об'єдналися).
/// </summary>
public class T062_MergeIntervals
{
    private const string TASK_NUMBER = "062";
    
    public static void Run(int[][] intervals)
    {
        var sorted = Sort(intervals);
        List<int[]> result = new List<int[]>();
        
        result.Add(sorted[0]);
        
        for (int i = 1; i < intervals.Length; i++)
        {
            int[] lastInterval = result[result.Count - 1];
            int[] current = sorted[i];

            if (lastInterval[1] >= current[0])
            {
                lastInterval[1] = Math.Max(current[1], lastInterval[1]);
            }
            else
            {
                result.Add(current);
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - Merged intervals: [{string.Join(", ", result.Select(x => $"[{x[0]}, {x[1]}]"))}]");
    }

    private static int[][] Sort(int[][] intervals)
    {
        for (int i = 0; i < intervals.Length - 1; i++)
        {
            bool swapped = false;
            
            for (int j = 0; j < intervals.Length - i - 1; j++)
            {
                if (intervals[j][0] > intervals[j + 1][0])
                {
                    int[] temp = intervals[j];
                    intervals[j] = intervals[j + 1];
                    intervals[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
        
        return intervals;
    }
}