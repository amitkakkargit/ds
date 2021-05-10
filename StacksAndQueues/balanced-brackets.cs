using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.StacksAndQueues
{
    public class balanced_brackets
    {
        // Complete the isBalanced function below.
        static string isBalanced(string s)
        {
            var bracketsMap = new Dictionary<char, char>();
            bracketsMap.Add('{', '}');
            bracketsMap.Add('[', ']');
            bracketsMap.Add('(', ')');
            bracketsMap.Add('}', '{');
            bracketsMap.Add(']', '[');
            bracketsMap.Add(')', '(');
            if (string.IsNullOrEmpty(s) || s.Length == 1 || s.Length % 2 != 0)
            {
                return "NO";
            }
            if (s.Length == 2)
            {
                if (s[0] == bracketsMap[s[1]])
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
            var closingBrackets = new char[] { '}', ')', ']' };
            if (closingBrackets.Contains(s[0]))
            {
                return "NO";
            }
            Stack<char> brackets = new Stack<char>();
            foreach (char bracket in s)
            {
                if (brackets.Count == 0)
                {
                    brackets.Push(bracket);
                }
                else if (brackets.Peek() == bracketsMap[bracket])
                {
                    brackets.Pop();
                }
                else if (closingBrackets.Contains(brackets.Peek()))
                {
                    return "NO";
                }
                else
                {
                    brackets.Push(bracket);
                }
            }
            if (brackets.Count != 0)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
    }
}
