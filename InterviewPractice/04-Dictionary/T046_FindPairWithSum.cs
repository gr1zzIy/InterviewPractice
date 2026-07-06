namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T046_FindPairWithSum.cs ⭐⭐⭐
/// Умова
/// Є список чисел.
/// Чи існує пара, яка дає задану суму?
/// </summary>
public class T046_FindPairWithSum
{
	private const string TASK_NUMBER = "046";
	
	public static void Run(int[] nums, int target)
	{
		string array = string.Join(", ", nums);
		var dict = new Dictionary<int, int>();
		
		for (int i = 0; i < nums.Length; i++ )
		{
			var diff = target - nums[i];
			
			if (dict.ContainsKey(diff))
			{
				Console.WriteLine($"{TASK_NUMBER} - [{array}] Found pair: {nums[i]} + {diff} = {target} | True");
				return;
			}

			dict[nums[i]] = i;
		}
		
		Console.WriteLine($"{TASK_NUMBER} - [{array}] No pair found | False");
	}
}