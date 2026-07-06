namespace InterviewPractice._05_HashSet;

/// <summary>
/// T051_RemoveDuplicates.cs ⭐
/// Умова
/// Є список чисел.
/// Повернути список без дублікатів.
/// Порядок появи потрібно зберегти.
/// </summary>
public class T051_RemoveDuplicates
{
	private const string TASK_NUMBER = "051";
	
	public static void Run(int[] numbers)
	{
		HashSet<int> set = new HashSet<int>(numbers);
		
		foreach (var num in numbers)
		{
			set.Add(num);
		}
		
		Console.WriteLine($"{TASK_NUMBER} - Original: [{string.Join(", ", numbers)}] => Without Duplicates: [{string.Join(", ", set)}]");
	}
}