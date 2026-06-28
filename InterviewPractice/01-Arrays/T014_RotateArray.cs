namespace InterviewPractice._01_Arrays;

/// <summary>
/// https://leetcode.com/problems/rotate-array/description/
/// </summary>
public class T014_RotateArray
{
    private const string TASK_NUMBER = "014";

    public static void Run(int[] nums, int k)
    {
        int length = nums.Length;
        
        if (length < 2)
            return;
        
        int[] array = (int[])nums.Clone();
    }
}