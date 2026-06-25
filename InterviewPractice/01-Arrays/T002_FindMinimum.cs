namespace InterviewPractice._01_Arrays;

public class T002_FindMinimum
{
    private const string TASK_NUMBER = "001";
    
    public static void Run(int[] numbers)
    {
        int length = numbers.Length;
        
        if (length == 0)
        {
            numbers = [7, 2, 15, 4, 10];
        }

        // Console.WriteLine($"{TASK_NUMBER} - The minimum number in the array is: {numbers.Min()}");
        
        int min = numbers[0];

        for (int i = 0; i < length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The minimum number in the array is: {min}");
    }
}