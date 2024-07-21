namespace LeetCodeSolution;

public class ReverseWordsStringIii557
{
    public string ReverseWords(string s)
    {
        string answer = "";
        string[] array = s.Split(new Char[] { ' ' });

        foreach (var item in array)
        {
            for (int i = item.Length; i>0; i--)
            {
                answer += item[i];
            }
            answer += " ";
        }

        return answer.Remove(answer.Length-1);
    }
}