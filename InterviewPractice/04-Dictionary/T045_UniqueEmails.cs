namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T045_UniqueEmails.cs ⭐⭐⭐⭐
/// Умова
/// Порахувати кількість унікальних email.
/// Правила Gmail:
/// До символу '+' усе після нього ігнорується.
/// Крапки в локальній частині не враховуються.
/// </summary>
public class T045_UniqueEmails
{
	private const string TASK_NUMBER = "045";
	
	public static void Run(List<string> emails)
	{
		var clearParts = GetPartsForComparsion(emails);
		var uniqueParts = new Dictionary<string, bool>();
		
		foreach (var part in clearParts)
		{
			uniqueParts.TryAdd(part, true);
		}
		
		var count = uniqueParts.Count(x => x.Value);
		
		Console.WriteLine($"{TASK_NUMBER} - Unique emails: {count}");
	}
	
	private static List<string> GetPartsForComparsion(List<string> emails)
	{
		return emails.Select(x => x.Split('+')[0]
						.Split('@')[0]
						.Replace(".", "")
						.ToLowerInvariant())
				.ToList();
	}
}