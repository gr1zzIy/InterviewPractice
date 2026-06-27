namespace InterviewPractice._01_Arrays;

/// <summary>
/// Умова
/// Є масив чисел.
/// Перемістити всі 0 в кінець, зберігаючи порядок інших чисел.
/// </summary>
public class T008_MoveZerosToEnd
{
    private const string TASK_NUMBER = "008";

    public static void Run(int[] numbers)
    {
        int[] array = (int[])numbers.Clone();
        int length = array.Length;
        
        if (length == 0)
            return;

        int[] result = new int[length];
        int zeroCount = 0;
        
        for (int i = 0; i < length; i++)
        {
            if (array[i] == 0)
            {
                zeroCount++;
                continue;
            }
            
            result[i-zeroCount] = array[i];
        }

        for (int i = 0; i < zeroCount; i++)
        {
            result[length - 1 - i] = 0;
        }
        
        string originalString = string.Join(", ", array);
        string resultString = string.Join(", ", result);
        
        Console.WriteLine($"{TASK_NUMBER} - Result: \n\toriginal: {originalString}\n\tresult: {resultString}");
    }
}