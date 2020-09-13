public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        int j = 0;

        if (nums.Length <= 1)
        {
            return nums.Length;
        }

        for (int i = 1; i < n; ++i)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[++j] = nums[i];
            }
        }

        return j + 1;
    }
}