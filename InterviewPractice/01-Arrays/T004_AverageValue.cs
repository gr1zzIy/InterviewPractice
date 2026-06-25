namespace InterviewPractice._01_Arrays;

public class T004_AverageValue
{
    private const string TASK_NUMBER = "004";

    public static void Run(int[] numbers)
    {
        // Console.WriteLine($"{TASK_NUMBER} - The average value of the array is: {numbers.Average()}");
        
        int length = numbers.Length;

        if (length == 0)
        {
            numbers = [7, 2, 15, 4, 10];
        }

        double average = 0;

        for (int i = 0; i < length; i++)
        {
            average += numbers[i];
            
            if (i == length - 1)
            {
                average /= length;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The average value of the array is: {average}");
    }
}