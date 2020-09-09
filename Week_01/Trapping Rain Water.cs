public class Solution
{
    public int Trap(int[] height)
    {
        if (height.Length <= 2) return 0;

        int n = height.Length;
        int head = 0;
        int tail = n - 1;
        int leftMax = height[0];
        int rightMax = height[n - 1];
        int ans = 0;

        while (head < tail)
        {
            leftMax = Math.Max(leftMax, height[head]);
            rightMax = Math.Max(rightMax, height[tail]);

            if (leftMax < rightMax) ans += leftMax - height[head++];
            else ans += rightMax - height[tail--];
        }

        return ans;
    }
}