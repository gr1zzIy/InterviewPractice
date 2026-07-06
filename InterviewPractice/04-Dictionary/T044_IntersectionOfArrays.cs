using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T044_IntersectionOfArrays.cs ⭐⭐⭐
/// Умова
/// Є два масиви.
/// Повернути лише спільні елементи.
/// Без дублікатів.
/// </summary>
public class T044_IntersectionOfArrays
{
	private const string TASK_NUMBER = "044";
	
	public static void Run(int[] first, int[] second)
	{
		var dict = new Dictionary<int, int>();
		
		foreach (var num in first)
		{
			dict.TryAdd(num, 1);
		}
		
		foreach (var num in second)
		{
			if (dict.ContainsKey(num))
			{
				dict[num]++;
			}
		}
		
		var result = string.Join(", ",dict
				.Where(x => x.Value > 1)
				.Select(x => x.Key));
		
		var arrayFirst = string.Join(", ", first);
		var arraySecond = string.Join(", ", second);
		
		Console.WriteLine($"{TASK_NUMBER}:\n\tFirst: {arrayFirst}\n\tSecond: {arraySecond}\n\tIntersection of arrays: [{result}]");
	}
}