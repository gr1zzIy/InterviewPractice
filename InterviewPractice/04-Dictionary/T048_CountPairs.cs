namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T048_CountPairs.cs ⭐⭐⭐⭐
/// Умова
/// Порахувати кількість пар однакових чисел.
/// </summary>
public class T048_CountPairs
{
	private const string TASK_NUMBER = "048";
	
	public static void Run(int[] numbers)
	{
		var dict = new Dictionary<int, int>();
		
		foreach (var num in numbers)
		{
			if (!dict.TryAdd(num, 1))
			{
				dict[num]++;
			}
		}
		
		Console.WriteLine($"{TASK_NUMBER} - Count pairs: {dict.Where(x=>x.Value > 1).ToList().Count}");
	}
}