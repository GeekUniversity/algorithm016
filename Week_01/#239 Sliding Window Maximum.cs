public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int n = nums.Length;
        int[] ans = new int[n - k + 1];
        int index = 0;
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; ++i)
        {
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i - k + 1 >= 0)
            {
                ans[index++] = nums[deque.First.Value];
            }
        }

        return ans;
    }
}