namespace InterviewPractice._01_Arrays;

public class T013_MergeTwoSortedArrays
{
    private const string TASK_NUMBER = "013";

    public static void Run(int[] nums1, int[] nums2)
    {
        int length = nums1.Length + nums2.Length;
        
        string originalString1 = string.Join(", ", nums1);
        string originalString2 = string.Join(", ", nums2);
        
        if (length < 2)
        {
            Console.WriteLine($"{TASK_NUMBER} - Merged sorted array: [{originalString1}{originalString2}]");
            return;
        }
        
        int[] array1 = (int[])nums1.Clone();
        int[] array2 = (int[])nums2.Clone();
        
        int[] result = new int[length];

        int p1 = 0;
        int p2 = 0;
        int pR = 0;

        while (p1 < array1.Length && p2 < array2.Length)
        {
            if (array1[p1] <= array2[p2])
            {
                result[pR] = array1[p1];
                p1++;
            }
            else
            {
                result[pR] = array2[p2];
                p2++;
            }
            pR++;
        }

        while (p1 < array1.Length)
        {
            result[pR] = array1[p1];
            p1++;
            pR++;
        }

        while (p2 < array2.Length)
        {
            result[pR] = array2[p2];
            p2++;
            pR++;
        }
        
        string mergedString = string.Join(", ", result);
        
        Console.WriteLine($"{TASK_NUMBER} - \n\tArr1: {originalString1}\n\tArr2: {originalString2}\n\tMerged sorted array: [{mergedString}]");
    }
}