public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int j = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != 0)
            {
                if (i > j)
                {
                    nums[j] = nums[i];
                    nums[i] = 0;
                }

                ++j;
            }
        }
    }
}