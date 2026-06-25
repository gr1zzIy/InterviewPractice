namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Дано масив цілих чисел.
/// Порахувати кількість парних чисел у масиві.
/// </summary>
public static class T007_CountEvenNumbers
{
    private const string TASK_NUMBER = "007";

    public static void Run(int[] numbers)
    {
        // Console.WriteLine($"{TASK_NUMBER} - The count of even numbers is: {numbers.Count(number => number % 2 == 0)}");

        int count = 0;
        
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        
        Console.WriteLine($"{TASK_NUMBER} - The count of even numbers is: {count}");
    }
}