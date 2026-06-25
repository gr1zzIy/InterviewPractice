namespace InterviewPractice._01_Arrays;

/*
 *
 * Умова
 * Дано масив цілих чисел.
 * Знайти найбільший елемент.
 * 
 */

public static class T001_FindMaximum
{
    private const string TASK_NUMBER = "001";
    
    public static void Run(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            numbers = [7, 2, 15, 4, 10];
        }
        
        int max = numbers[0];
        
        // Console.WriteLine($"{TASK_NUMBER} - The maximum number is: {numbers.Max()}");

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The maximum number is: {max}");
    }
}