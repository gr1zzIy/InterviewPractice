namespace InterviewPractice._07_Queue___08_Stack;

/// <summary>
/// T068_EvaluateReversePolishNotation.cs
/// Умова: Обчислити значення арифметичного виразу у зворотній польській нотації (постфіксна нотація) за допомогою стека.
/// Операндами можуть бути числа або знаки +, -, *, /.
/// Вхід: string[] { "2", "1", "+", "3", "*" } (що еквівалентно (2 + 1) * 3)
/// Результат: Число 9.
/// </summary>
public class T068_EvaluateReversePolishNotation
{
	private const string TASK_NUMBER = "068";
	
	public static void Run(string[] tokens)
	{
		Stack<int> stack = new Stack<int>();
		
		foreach (string token in tokens)
		{
			if (int.TryParse(token, out int num))
			{
				stack.Push(num);
			}
			else
			{
				int a = stack.Pop();
				int b = stack.Pop();
				int result = token switch
				{
					"+" => b + a,
					"-" => b - a,
					"*" => b * a,
					"/" => b / a,
					_ => throw new InvalidOperationException($"Invalid operator: {token}")
				};
				stack.Push(result);
			}
		}
		
		Console.WriteLine($"{TASK_NUMBER} - [{string.Join(", '", tokens)}] -> Результат: {stack.Pop()}");
	}
}