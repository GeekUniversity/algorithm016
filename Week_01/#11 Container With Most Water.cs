public class Solution
{
    public int MaxArea(int[] height)
    {
        int head = 0;
        int tail = height.Length - 1;
        int max = 0;

        while (head < tail)
        {
            int area = (tail - head) * Math.Min(height[head], height[tail]);
            max = Math.Max(max, area);
            if (height[head] < height[tail])
            {
                ++head;
            }
            else
            {
                --tail;
            }
        }

        return max;
    }
}