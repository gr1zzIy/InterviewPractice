namespace InterviewPractice._02_Lists;

public class T019_MergeLists
{
    private const string TASK_NUMBER = "019";

    public static void Run(List<int> list1, List<int> list2)
    {
        List<int> mergedList = new List<int>(list1);
        mergedList.AddRange(list2);
        //mergedList.Sort();

        Console.WriteLine($"{TASK_NUMBER} - {string.Join(", ", mergedList)}");
    }
}