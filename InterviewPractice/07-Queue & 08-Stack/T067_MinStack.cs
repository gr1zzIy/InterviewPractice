namespace InterviewPractice._07_Queue___08_Stack;

/// <summary>
/// T067_MinStack.cs
/// Умова: Спроектувати кастомний клас MinStack,
/// який підтримує стандартні операції (Push, Pop, Top),
/// а також метод GetMin, який повертає мінімальний елемент у стеку.
/// Усі операції мають працювати за O(1) часу.
/// Підказка: використовуй внутрішньо два стеки.
/// Результат: Послідовні виклики методів коректно трекають поточний мінімум,
/// навіть після видалення елементів через Pop.
/// </summary>
public class T067_MinStack
{
	private const string TASK_NUMBER = "067";
	
	public static void Run()
	{
		MinStack stack = new MinStack();

		stack.Push(1);
		stack.Push(-2);
		stack.Push(6);
		stack.Push(-3);
		stack.Push(4);
		stack.Push(-10);
		Console.WriteLine($"{TASK_NUMBER} - Stack: {stack.Print()}");
		Console.WriteLine($"{TASK_NUMBER} - Min: {stack.GetMin()}");
		stack.Pop();
		Console.WriteLine($"{TASK_NUMBER} - Stack: {stack.Print()}");
		Console.WriteLine($"{TASK_NUMBER} - Min: {stack.GetMin()}");
		stack.Top();
		
		Console.WriteLine($"{TASK_NUMBER} - Stack after top(peak): {stack.Print()}");
	}
}

class MinStack
{
	Stack<int> stack = new Stack<int>();
	Stack<int> minStack = new Stack<int>();
	
	public void Pop()
	{
		if (stack.Count == 0)
		{
			throw new InvalidOperationException("Stack is empty.");
		}
		
		if (stack.Peek() == minStack.Peek())
		{
			minStack.Pop();
		}

		stack.Pop();
	}
	
	public void Push(int n)
	{
		stack.Push(n);
		
		if (minStack.Count == 0 || n <= minStack.Peek())
		{
			minStack.Push(n);
		}
		else
		{
			minStack.Push(minStack.Peek());
		}
	}
	
	public int Top()
	{
		return stack.Peek();
	}
	
	public int GetMin()
	{
		return minStack.Peek();
	}
	
	public string Print()
	{
		return string.Join(", ", stack);
	}
}