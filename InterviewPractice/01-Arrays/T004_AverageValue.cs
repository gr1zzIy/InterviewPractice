namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Порахувати середнє значення елементів масиву.
/// </summary>
public static class T004_AverageValue
{
    private const string TASK_NUMBER = "004";

    public static void Run(int[] numbers)
    {
        int[] array = (int[])numbers.Clone();
        
        // Console.WriteLine($"{TASK_NUMBER} - The average value of the array is: {array.Average()}");
        
        int length = array.Length;

        double average = 0;

        for (int i = 0; i < length; i++)
        {
            average += array[i];
            
            if (i == length - 1)
            {
                average /= length;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The average value of the array is: {average}");
    }
}