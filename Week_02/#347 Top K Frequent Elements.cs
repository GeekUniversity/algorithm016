public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int n = nums.Length;
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < n; ++i)
        {
            if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], 1);
            else ++dic[nums[i]];
        }

        k = Math.Min(dic.Keys.Count, k);

        var buckets = new List<int>[n + 1];
        foreach (var key in dic.Keys)
        {
            if (buckets[dic[key]] == null) buckets[dic[key]] = new List<int>();
            buckets[dic[key]].Add(key);
        }

        int count = 0;
        int[] ans = new int[k];
        for (int j = n; j > 0; --j)
        {
            if (buckets[j] == null) continue;
            for (int m = 0; m < buckets[j].Count; ++m)
            {
                ans[count++] = buckets[j][m];
                if (count == k) return ans;
            }
        }

        return ans;
    }
}