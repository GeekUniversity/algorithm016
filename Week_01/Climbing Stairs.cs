public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        int p1 = 1;
        int p2 = 2;
        int res = p1 + p2;

        for (int i = 3; i <= n; ++i)
        {
            res = p1 + p2;
            p1 = p2;
            p2 = res;
        }

        return res;
    }
}