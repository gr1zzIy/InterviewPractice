using System.Text;

namespace InterviewPractice._05_HashSet;

/// <summary>
/// T059_UniqueWords.cs ⭐⭐
/// Умова
/// Є текст.
/// Порахувати кількість унікальних слів.
/// Регістр ігнорувати.
/// </summary>
public class T059_UniqueWords
{
	private const string TASK_NUMBER = "059";
	
	public static void Run(List<string> sentences)
	{
		HashSet<string> uniqueWords = new HashSet<string>();
		StringBuilder result = new StringBuilder();
		string originalSentences = string.Join("\n\t", sentences);
		
		foreach (var sentence in sentences)
		{
			string[] words = sentence
					.ToLowerInvariant()
					.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			
			foreach (var word in words)
			{
				uniqueWords.Add(word);
			}
		}
		
		foreach (var word in uniqueWords)
		{
			result.AppendLine(word);
		}
		
		Console.WriteLine($"{TASK_NUMBER} - Unique words: {uniqueWords.Count}");
	}
}