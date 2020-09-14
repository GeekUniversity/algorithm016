public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {

        int n = heights.Length;
        int ans = 0;
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i <= n;)
        {
            int currHeight = i == n ? 0 : heights[i];

            if (!stack.Any() || currHeight >= heights[stack.Peek()])
            {
                stack.Push(i++);
            }
            else
            {
                int lastHeight = heights[stack.Pop()];
                int end = i - 1;
                int begin = !stack.Any() ? -1 : stack.Peek();
                int width = end - begin;
                ans = Math.Max(ans, lastHeight * width);
            }
        }

        return ans;
    }
}