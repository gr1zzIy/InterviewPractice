namespace InterviewPractice._05_HashSet;

/// <summary>
/// T060_UniqueVisitors.cs ⭐⭐
/// Умова
/// Є список UserId.
/// Порахувати кількість унікальних користувачів.
/// </summary>
public class T060_UniqueVisitors
{
	private const string TASK_NUMBER = "060";
	
	public static void Run(List<int> userIds)
	{
		HashSet<int> uniqueVisitors = new HashSet<int>();

		foreach (var userId in userIds)
		{
			uniqueVisitors.Add(userId);
		}
		
		// HashSet<int> uniqueVisitors = new HashSet<int>(userIds); // в одну стрічку
		string originalUserIds = string.Join(", ", userIds);
		
		Console.WriteLine($"{TASK_NUMBER} - Original: [{originalUserIds}] => Unique visitors: {uniqueVisitors.Count}");
		
	}
}