using InterviewPractice._01_Arrays;

namespace InterviewPractice;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayTasks();
        
        Console.WriteLine(@"
--------------------
All for improvement!");
    }

    private static void ArrayTasks()
    {
        T001_FindMaximum.Run([7, 2, 15, 4, 10]);
        T002_FindMinimum.Run([7, 2, 15, 4, 10]);
        T003_SumOfArray.Run([7, 2, 15, 4, 10]);
        T004_AverageValue.Run([7, 2, 15, 4, 10]);
    }
}