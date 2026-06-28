namespace InterviewPractice._02_Lists;

public class T016_RemoveNegativeNumbers
{
    private const string TASK_NUMBER = "016";

    public static void Run(List<int> nums)
    {
        var resultStr = $"{string.Join(", ", nums.Where(x => x >= 0).ToList())}";
        
        Console.WriteLine($"{TASK_NUMBER} - {resultStr}");
    }
}