namespace LeetCodeSolution;

public class ReverseWords
{
    public string ReverseToWords(string s)
    {
        var us = s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse();
        string result = string.Join(" ", us);

        return result;
    }
}