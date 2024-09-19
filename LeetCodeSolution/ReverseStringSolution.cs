namespace LeetCodeSolution;

public class ReverseStringSolution
{
    public void ReverseString(char[] s)
    {

        for (int i = 0; i < s.Length; i++)
        {
            s[i] = s[^(i+1)];

            Console.WriteLine(s[i]);
        }
        
        
    }
}