namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T049_MostFrequentNumber.cs ⭐⭐⭐
/// Умова
/// Знайти число, яке зустрічається найчастіше.
/// Якщо таких декілька — повернути те, яке з'явилось раніше.
/// </summary>
public class T049_MostFrequentNumber
{
	private const string TASK_NUMBER = "049";
	
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

		var mostFrequentNumber = dict.OrderByDescending(x => x.Value).FirstOrDefault().Key;
		
		Console.WriteLine($"{TASK_NUMBER} - Most frequent number: {mostFrequentNumber}");
	}
}