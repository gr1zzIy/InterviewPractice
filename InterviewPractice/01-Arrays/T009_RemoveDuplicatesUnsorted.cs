namespace InterviewPractice._01_Arrays;

public class T009_RemoveDuplicatesUnsorted
{
    private const string TASK_NUMBER = "009";

    public static void Run(int[] numbers)
    {
        int length = numbers.Length;
        
        if  (length == 0 || length == 1)
            return;
        
        int[] temp = new int[length];
        HashSet<int> uniqueNumbers = new HashSet<int>();

        for (int i = 0; i < length; i++)
        {
            if (uniqueNumbers.Add(numbers[i]))
            {
                temp[uniqueNumbers.Count - 1] = numbers[i];
            }
        }

        int[] result = new int[uniqueNumbers.Count];
        
        for (int i = 0; i < uniqueNumbers.Count; i++)
        {
            result[i] = temp[i];
        }
        
        string originalString = string.Join(", ", numbers);
        string resultString = string.Join(", ", result);
        
        Console.WriteLine($"{TASK_NUMBER} - Result: \n\toriginal: {originalString}\n\tresult: {resultString}");

    }
}