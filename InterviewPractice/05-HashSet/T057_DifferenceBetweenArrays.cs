namespace InterviewPractice._05_HashSet;

/// <summary>
/// T057_DifferenceBetweenArrays.cs ⭐⭐
/// Умова
/// Повернути елементи першого списку, яких немає у другому.
/// </summary>
public class T057_DifferenceBetweenArrays
{
	private const string TASK_NUMBER = "057";
	
	public static void Run(int[] first, int[] second)
	{
		HashSet<int> diff = new HashSet<int>(first);
		string originalFirst = string.Join(", ", first);
		string originalSecond = string.Join(", ", second);
		
		foreach (var num in second)
		{
            diff.Remove(num);
        }
		
		string result = string.Join(", ", diff);
		
		Console.WriteLine($"{TASK_NUMBER}   - First:  [{originalFirst}]\n\tSecond: [{originalSecond}]\n\t\t=> Result: [{result}]");
	}
}