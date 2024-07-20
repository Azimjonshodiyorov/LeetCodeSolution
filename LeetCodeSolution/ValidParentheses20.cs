using System.Collections;

namespace LeetCodeSolution;

public class ValidParentheses20
{
    public bool Valid(string s)
    {

        #region  1-usul
        // Dictionary<char, char> dictionary = new Dictionary<char, char>();
        //
        // dictionary.Add('(',')');
        // dictionary.Add('{','}');
        // dictionary.Add('[',']');
        // Stack<char> stack = new Stack<char>();
        //
        // foreach (var itms in s)
        // {
        //     if (dictionary.ContainsKey(itms))
        //     {
        //         stack.Push(itms);
        //     }
        //     else
        //     {
        //         if (stack.Count == 0)
        //         {
        //             return false;
        //         }
        //
        //         char topElement = stack.Pop();
        //         if (dictionary[topElement] != itms)
        //             return false;
        //         
        //     }
        // }
        // return stack.Count == 0;
        #endregion


        #region 2-usul

        Stack<char> stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '(')
            {
                stack.Push(')');
            }
            else if(c== '{')
            {
                stack.Push('}');
            }
            else if(c=='[')
            {
                stack.Push(']');
            }
            else if(stack.Count == 0 || c != stack.Pop())
            {
                return false;
            }

            
        }
        return stack.Count == 0;
        #endregion
    }
}