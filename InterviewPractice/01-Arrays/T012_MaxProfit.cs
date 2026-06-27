namespace InterviewPractice._01_Arrays;

/// <summary>
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
/// </summary>
public class T012_MaxProfit
{
    private const string TASK_NUMBER = "012";

    public static void Run(int[] prices)
    {
        int[] array = (int[])prices.Clone();
        int length = array.Length;
        int maxProfit = 0;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] - array[i] > maxProfit)
                {
                    maxProfit = array[j] - array[i];
                }
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The max profit is: {maxProfit}");
    }
}