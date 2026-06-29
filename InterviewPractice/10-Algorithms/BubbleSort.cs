namespace InterviewPractice._09_Algorithms;

/// <summary>
/// Бульбашкове сортування O(n^2)
/// </summary>
public class BubbleSort
{
    public static int[] Execute(int[] array, int length = 0)
    {
        if (array.Length < 2)
            return array;
        
        int[] arrayLocal = (int[])array.Clone();
        int temp;
        bool swapped;
        
        if (length == 0)
        {
            length = arrayLocal.Length;
        }
        
        for (int i = 0; i < length - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < length - i - 1; j++)
            {
                if (arrayLocal[j] > arrayLocal[j + 1])
                {
                    temp = arrayLocal[j];
                    arrayLocal[j] = arrayLocal[j + 1];
                    arrayLocal[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }

        return arrayLocal;
    }
}