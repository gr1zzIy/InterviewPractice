namespace InterviewPractice._01_Arrays;

/// <summary>
/// https://leetcode.com/problems/two-sum/
/// </summary>
public class T011_TwoSum
{
    private const string TASK_NUMBER = "011";

    public static void Run(int[] nums, int target)
    {
        int[] array = (int[])nums.Clone();
        int length = array.Length;
        int[] result = new int[2];

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (array[i] + array[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    Console.WriteLine($"{TASK_NUMBER} - Result: [{string.Join(", ", result)}]");
                    return;
                }
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - No two sum solution found.");
    }
}