public class Solution
{
    public bool IsAnagram(string s, string t)
    {

        if (s.Length != t.Length) return false;

        int count = 26;

        int[] all = new int[count];

        for (int i = 0; i < s.Length; ++i)
        {
            ++all[s[i] - 'a'];
            --all[t[i] - 'a'];
        }

        for (int j = 0; j < count; ++j)
        {

            if (all[j] < 0) return false;
        }

        return true;
    }
}