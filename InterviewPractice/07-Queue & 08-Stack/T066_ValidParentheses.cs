namespace InterviewPractice._07_Queue___08_Stack;

/// <summary>
/// T066_ValidParentheses.cs
/// Умова: Дано рядок, що містить лише символи (), [], {}.
/// Перевірити за допомогою Stack<char>, чи є послідовність дужок правильною
/// (кожна відкрита дужка має закриватися дужкою того ж типу у правильному порядку).
/// Вхід: "()[]{}" -> Результат: true
/// Вхід: "(]" -> Результат: false
/// </summary>
public class T066_ValidParentheses
{
	private const string TASK_NUMBER = "066";

	private static readonly Dictionary<char, char> pairs = new Dictionary<char, char>()
	{
		{'}', '{'},
		{']', '['},
		{')', '('}
	};
	
	public static void Run(string s)
	{
		var stack = new Stack<char>();
		
		foreach (var c in s)
		{
			if (pairs.TryGetValue(c, out var pair))
			{
				if (stack.Count == 0 || stack.Pop() != pair)
				{
					Console.WriteLine($"T{TASK_NUMBER}: {s} -> Результат: false");
					return;
				}
			}
			else
			{
				stack.Push(c);
			}
		}
		
		Console.WriteLine($"T{TASK_NUMBER}: {s} -> Результат: true");
	}
}