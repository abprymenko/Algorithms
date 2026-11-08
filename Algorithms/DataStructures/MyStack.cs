namespace Algorithms.DataStructures;

#region MyStack
public class MyStack
{
    /*
    Valid Parentheses
    This is an absolute classic for understanding the LIFO (Last In, First Out) principle.
    Condition: Given a string s that contains only the parentheses characters: '(', ')', '{', '}', '[', ']'.
    You need to determine whether this string is a valid parenthetical sequence.
    A string is valid if:
    The open parentheses are closed by parentheses of the same type.
    The parentheses are closed in the correct order (for example, "{[]}" is valid, but "([" or "(]" is not).
    ()[]{} ([]({}))
    */
    public static bool IsValid(string s)
    {
        if (string.IsNullOrWhiteSpace(s) || s.Length % 2 != 0)
            return false;
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            switch (ch)
            {
                case '(':
                    stack.Push(')');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                default:
                    if (stack.Count == 0 || stack.Pop() != ch)
                        return false;
                    break;
            }
        }
        return stack.Count == 0;
    }
}
#endregion