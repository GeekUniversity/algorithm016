public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        int n = strs.Length;
        var dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; ++i)
        {
            char[] chars = new char[26];

            for (int j = 0; j < strs[i].Length; ++j)
            {
                ++chars[strs[i][j] - 'a'];
            }

            var key = new String(chars);

            if (!dic.ContainsKey(key)) dic.Add(key, new List<string>());
            dic[key].Add(strs[i]);
        }

        return new List<IList<string>>(dic.Values);
    }
}