namespace InterviewPractice._04_Dictionary;

/// <summary>
/// T042_IsomorphicStrings.cs ⭐⭐⭐
/// Умова
/// Два рядки є ізоморфними, якщо символи одного можна однозначно замінити символами іншого.
/// </summary>
public class T042_IsomorphicStrings
{
    private const string TASK_NUMBER = "042";

    public static void Run(List<string> words)
    {
        if (words[0].Length != words[1].Length)
        {
            Console.WriteLine($"{TASK_NUMBER} - False");
            return;
        }
        
        string s = words[0];
        string t = words[1];

        if (IsIsomorphic(s, t))
        {
            Console.WriteLine($"{TASK_NUMBER} - True");
        }
        else
        {
            Console.WriteLine($"{TASK_NUMBER} - False");
        }
    }

    private static bool IsIsomorphic(string s, string t)
    {
        var mapST = new Dictionary<char, char>();
        var mapTS = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char cS = s[i];
            char cT = t[i];

            if (mapST.TryGetValue(cS, out var value))
            {
                if(value != cT)
                {
                    return false;
                }
            }
            else
            {
                mapST[cS] = cT;
            }
            
            if (mapTS.TryGetValue(cT, out var valueT))
            {
                if(valueT != cS)
                {
                    return false;
                }
            }
            else
            {
                mapTS[cT] = cS;
            }
        }
        
        return true;
    }
}