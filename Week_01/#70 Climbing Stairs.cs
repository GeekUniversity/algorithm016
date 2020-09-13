public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2) return n;
        
        int s1 = 1;
        int s2 = 2;
        int ans = 0;
        
        for (int i = 3; i <= n; ++ i) {
            ans = s1 + s2;
            s1 = s2;
            s2 = ans;
        }
        
        return ans;
    }
}