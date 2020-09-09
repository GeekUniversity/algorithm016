public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();
        int n = nums.Length;

        Array.Sort(nums);

        for (int i = 0; i < n - 2; ++i)
        {
            int head = i + 1;
            int tail = n - 1;
            int target = -nums[i];

            if (i > 0 && nums[i] == nums[i - 1]) continue;

            while (head < tail)
            {
                if (nums[head] + nums[tail] == target)
                {
                    res.Add(new List<int> { -target, nums[head], nums[tail] });
                    ++head;
                    --tail;
                    while (head < tail && nums[head - 1] == nums[head]) ++head;
                    while (head < tail && nums[tail] == nums[tail + 1]) --tail;
                }
                else if (nums[head] + nums[tail] > target) tail--;
                else head++;
            }
        }

        return res;
    }
}