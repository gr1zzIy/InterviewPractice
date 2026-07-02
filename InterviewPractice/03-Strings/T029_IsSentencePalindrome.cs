namespace InterviewPractice._03_Strings;

/// <summary>
/// Задача 029 — Is Sentence Palindrome
/// Умова
/// Перевірити, чи є речення паліндромом.
/// Ігнорувати:
/// пробіли
/// регістр
/// розділові знаки
/// </summary>
public class T029_IsSentencePalindrome
{
    private const string TASK_NUMBER = "029";
    
    public static void Run(string input)
    {
        bool isPalindrome = false;
        
        input = input.ToLower().Trim();
        int length = input.Length - 1;

        for (int i = 0; i < length / 2; i++)
        {
            if (char.IsLetter(input[i]) && char.IsLetter(input[length - i]))
            {
                if (input[i] == input[length - i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }    
            }
            else
            {
                input = input.Remove(i, 1);
                i--;
                length--;
            }
        }
        
        
        Console.WriteLine($"{TASK_NUMBER} - The sentence is a palindrome: {isPalindrome}");
    }
}