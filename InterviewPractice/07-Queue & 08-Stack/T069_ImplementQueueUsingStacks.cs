namespace InterviewPractice._07_Queue___08_Stack;

/// <summary>
/// T069_ImplementQueueUsingStacks.cs
/// Умова: Реалізувати чергу (FIFO) за допомогою двох стеків (LIFO).
/// Клас має підтримувати методи Enqueue(x), Dequeue(), Peek(), Empty().
/// Результат: Поведінка класу повністю відповідає стандартній черзі,
/// хоча під капотом немає масивів чи списків, крім Stack<T>.
/// </summary>
public class T069_ImplementQueueUsingStacks
{
	private const string TASK_NUMBER = "069";

	public static void Run()
	{
		var queue = new MyQueue<int>();

		Console.WriteLine($"=== START {TASK_NUMBER}: Implement Queue Using Stacks ===");
		Console.WriteLine();

		Console.WriteLine("--- Phase 1: Initialization & Enqueue ---");
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);
		queue.Print(); // Очікувано: 1, 2, 3
		Console.WriteLine();

		Console.WriteLine("--- Phase 2: First Dequeues ---");
		Console.WriteLine($"[Pop] Dequeued: {queue.Dequeue()} (Expected: 1)");
		Console.WriteLine($"[Pop] Dequeued: {queue.Dequeue()} (Expected: 2)");
		queue.Print(); // Очікувано: 3
		Console.WriteLine();

		Console.WriteLine("--- Phase 3: Interleaved Operations & Peek ---");
		queue.Enqueue(4);
		queue.Enqueue(5);
		queue.Print(); // Очікувано: 3, 4, 5

		Console.WriteLine($"[Peek] Front element: {queue.Peek()} (Expected: 3)");
		Console.WriteLine($"[Peek] Front element: {queue.Peek()} (Expected: 3)"); // Стан не змінюється
		Console.WriteLine();

		Console.WriteLine("--- Phase 4: Emptying the Queue ---");
		Console.WriteLine($"[Pop] Dequeued: {queue.Dequeue()} (Expected: 3)");
		Console.WriteLine($"[Pop] Dequeued: {queue.Dequeue()} (Expected: 4)");
		Console.WriteLine($"[Pop] Dequeued: {queue.Dequeue()} (Expected: 5)");

		Console.WriteLine($"Is queue empty? {queue.Empty()} (Expected: True)");
		queue.Print(); // Очікувано: (порожня черга)
		Console.WriteLine();

		Console.WriteLine("--- Phase 5: Exception Handling ---");
		try
		{
			Console.WriteLine("Attempting to dequeue from an empty queue...");
			queue.Dequeue();
		}
		catch (InvalidOperationException ex)
		{
			Console.WriteLine($"[Success] Caught expected exception: {ex.Message}");
		}
		Console.WriteLine();

		Console.WriteLine("--- Phase 6: Reuse After Emptying ---");
		queue.Enqueue(42);
		queue.Print(); // Очікувано: 42
		Console.WriteLine($"[Pop] Dequeued: {queue.Dequeue()} (Expected: 42)");

		Console.WriteLine();
		Console.WriteLine($"=== END {TASK_NUMBER}: Implement Queue Using Stacks ===");
	}
}
internal class MyQueue<T>
{
	private readonly Stack<T> _input;
	private readonly Stack<T> _output;

	public int Count => _input.Count + _output.Count;

	public MyQueue()
	{
		_input = new Stack<T>();
		_output = new Stack<T>();
	}

	public bool Empty()
	{
		return Count == 0;
	}

	public void Enqueue(T x)
	{
		_input.Push(x);
	}

	public T Dequeue()
	{
		MoveItemsToOutput();

		if (_output.Count == 0)
		{
			throw new InvalidOperationException("Черга пуста.");
		}

		return _output.Pop();
	}

	public T Peek()
	{
		MoveItemsToOutput();

		if (_output.Count == 0)
		{
			throw new InvalidOperationException("Черга пуста.");
		}

		return _output.Peek();
	}

	public void Print()
	{
		if (Count == 0)
		{
			Console.WriteLine("Queue contents: (порожня черга)");
			return;
		}

		// _output йде від вершини до низу (правильний черговий порядок)
		// _input розгортаємо, щоб він йшов від низу (старіші) до вершини (новіші)
		var elements = _output.Concat(_input.Reverse());

		Console.WriteLine($"Queue contents: {string.Join(", ", elements)}");
	}

	private void MoveItemsToOutput()
	{
		if (_output.Count > 0)
		{
			return;
		}

		while (_input.Count > 0)
		{
			_output.Push(_input.Pop());
		}
	}
}