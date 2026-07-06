namespace InterviewPractice._05_HashSet;

/// <summary>
/// T052_FindFirstDuplicate.cs ⭐⭐
/// Умова
/// Знайти перший елемент, який зустрівся повторно.
/// </summary>
public class T052_FindFirstDuplicate
{
	private const string TASK_NUMBER = "052";
	
	public static void Run(int[] numbers)
	{
		HashSet<int> set = new HashSet<int>();
		
		foreach (var num in numbers)
		{
			if (!set.Add(num))
			{
				Console.WriteLine($"{TASK_NUMBER} - Original: [{string.Join(", ", numbers)}] => First duplicate: {num}");
				return;
			}
		}
		
		Console.WriteLine($"{TASK_NUMBER} - No duplicate found.");
	}
}