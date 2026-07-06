using System.Text;

namespace InterviewPractice._04_Dictionary;

/// <summary>
/// Умова
/// Є список повідомлень.
/// Потрібно:
/// 1. Знайти всі хештеги.
/// 2. Порахувати кількість кожного.
/// 3. Відсортувати за спаданням.
/// 4. Якщо кількість однакова — сортувати алфавітно.
/// 5. Вивести Top 5.
/// </summary>
public class T050_MiniInterviewHashtags
{
	private const string TASK_NUMBER = "050";
	
	public static void Run(List<string> sentences)
	{
		var dict = new Dictionary<string, int>();
		var result = new StringBuilder();
		
		foreach (var sentence in sentences)
		{
			var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			
			foreach (var word in words)
			{
				if (word.StartsWith("#"))
				{
					if (!dict.TryAdd(word, 1))
					{
						dict[word]++;
					}
				}
			}
		}

		foreach (var record in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
		{
			result.AppendLine($"\t{record.Key} -> {record.Value}");
		}
		
		Console.WriteLine($"{TASK_NUMBER} - Mini Interview Hashtags:\n{result}");
	}
}