public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;

        k %= n;

        Reverse(nums, 0, n - k - 1);
        Reverse(nums, n - k, n - 1);
        Reverse(nums, 0, n - 1);
    }

    private void Reverse(int[] nums, int head, int tail)
    {
        while (head < tail)
        {
            var temp = nums[head];
            nums[head] = nums[tail];
            nums[tail] = temp;

            ++head;
            --tail;
        }
    }
}