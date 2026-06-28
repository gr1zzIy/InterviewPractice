namespace InterviewPractice._01_Arrays;

/// <summary>
/// https://leetcode.com/problems/product-of-array-except-self/description/
/// </summary>
public class T015_ProductofArrayExceptpSelf
{
    private const string TASK_NUMBER = "015";

    public static void Run(int[] nums)
    {
        int length = nums.Length;
        
        if (length < 2)
            return;
        
        int[] array = (int[])nums.Clone();
    }
}