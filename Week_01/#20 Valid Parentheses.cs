public class Solution
{
    public bool IsValid(string s)
    {
        var all = new Stack<char>();

        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(') all.Push(')');
            else if (s[i] == '[') all.Push(']');
            else if (s[i] == '{') all.Push('}');
            else
            {
                if (!all.Any() || s[i] != all.Pop()) return false;
            }
        }

        return !all.Any();
    }
}