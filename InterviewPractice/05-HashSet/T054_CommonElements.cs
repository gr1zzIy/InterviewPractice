namespace InterviewPractice._05_HashSet;

/// <summary>
/// T054_CommonElements.cs ⭐⭐
/// Умова
/// Повернути всі спільні елементи двох списків.
/// Без повторів.
/// </summary>
public class T054_CommonElements
{
    private const string TASK_NUMBER = "054";
    
    public static void Run(int[] list1, int[] list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> commonElements = new HashSet<int>();

        string originalList1 = string.Join(", ", list1);
        string originalList2 = string.Join(", ", list2);
        
        foreach (var number in list2)
        {
            if (set1.Contains(number))
            {
                commonElements.Add(number);
            }
        }
        
        string commonElementsString = string.Join(", ", commonElements);
        
        Console.WriteLine($"{TASK_NUMBER} -   Original List1: [{originalList1}],\n\tOriginal List2: [{originalList2}] \n\t\t=> Common elements: [{commonElementsString}]");
    }
}