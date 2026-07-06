using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T047_InvertDictionary.cs ⭐⭐⭐
/// Умова
/// Поміняти місцями ключ і значення.
/// </summary>
public class T047_InvertDictionary
{
	private const string TASK_NUMBER = "047";
	
	public static void Run(Dictionary<string, string> dictionary)
	{
		var invertedDictionary = new Dictionary<string, string>();
		var result = new StringBuilder();
		
		foreach (var record in dictionary)
		{
			invertedDictionary[record.Value] = record.Key;
		}

		foreach (var record in invertedDictionary)
		{
			result.AppendLine($"\t{record.Key} : {record.Value}");
		}
		
		Console.WriteLine($"{TASK_NUMBER} - Inverted dictionary:\n{result}");
	}
}