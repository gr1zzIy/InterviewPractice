namespace InterviewPractice._06_Sorting;

/// <summary>
/// T061_BubbleSortAndSelectionSort.cs
/// Умова: Написати вручну два класичні алгоритми сортування масиву цілих чисел:
/// 1. бульбашкою (Bubble)
/// 2. вибором (Selection).
/// Не використовувати Array.Sort().
/// Вхід: Масив int[] { 5, 2, 9, 1, 5 }
/// Результат: Масив відсортовано за зростанням: [1, 2, 5, 5, 9].
/// Обидва алгоритми мають працювати за час O(N^2).
/// </summary>
public class T061_BubbleSortAndSelectionSort
{
    public static int[] BubbleSort(int[] numbers)
    {
        if (numbers.Length < 2)
            return numbers;
        
        int temp = 0;
        bool swapped = false;
        
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            swapped = false;
            
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                    swapped = true;
                }
            }
            
            if (!swapped)
                break;
        }

        return numbers;
    }
    
    public static int[] SelectionSort(int[] numbers)
    {
        if (numbers.Length < 2)
            return numbers;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int min = i;
            
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[min])
                {
                    min = j;
                }
            }
            
            int temp = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = temp;
        }
        
        return numbers;
    }
}