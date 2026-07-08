namespace InterviewPractice._05_HashSet;

public class T058_SymmetricDifference
{
	private const string TASK_NUMBER = "058";
	
	public static void Run(int[] first, int[] second)
	{
		string originalFirst = string.Join(", ", first);
		string originalSecond = string.Join(", ", second);
		
		HashSet<int> set1 = new HashSet<int>(first);
		HashSet<int> set2 = new HashSet<int>(second);
		
		set1.SymmetricExceptWith(set2);
		
		string result = string.Join(", ", set1);
		
		Console.WriteLine($"{TASK_NUMBER}   - First:  [{originalFirst}]\n\tSecond: [{originalSecond}]\n\t\t=> Result: [{result}]");
	}
	
	private static void Version1(int[] first, int[] second, string originalFirst, string originalSecond)
	{
		HashSet<int> set1 = new HashSet<int>(first);
		HashSet<int> set2 = new HashSet<int>(second);
		
		HashSet<int> symmetricDifference = new HashSet<int>(set1);
		symmetricDifference.UnionWith(set2);
		
		HashSet<int> intersection = new HashSet<int>(set1);
		intersection.IntersectWith(set2);
		
		symmetricDifference.ExceptWith(intersection);
		
		string result = string.Join(", ", symmetricDifference);
		
		Console.WriteLine($"{TASK_NUMBER}   - First:  [{originalFirst}]\n\tSecond: [{originalSecond}]\n\t\t=> Result: [{result}]");
	}
	
	private static void Version2(int[] first, int[] second, string originalFirst, string originalSecond)
	{
		HashSet<int> set1 = new HashSet<int>(first);
		HashSet<int> set2 = new HashSet<int>(second);
		
		HashSet<int> symmetricDifference = new HashSet<int>();
		
		foreach (var num in set1)
		{
			if (!set2.Contains(num))
			{
				symmetricDifference.Add(num);
			}
		}
		
		foreach (var num in set2)
		{
			if (!set1.Contains(num))
			{
				symmetricDifference.Add(num);
			}
		}
		
		string result = string.Join(", ", symmetricDifference);
		
		Console.WriteLine($"{TASK_NUMBER}   - First:  [{originalFirst}]\n\tSecond: [{originalSecond}]\n\t\t=> Result: [{result}]");	
	}
}