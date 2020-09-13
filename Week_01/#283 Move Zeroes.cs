public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = nums.Length;
        if (n <= 1) return;
        
        int j = 0;
        for (int i = 0; i < n; ++ i) {
            if (nums[i] != 0) {
                if (i > j) {
                    nums[j] = nums[i];
                    nums[i] = 0;
                }
                
                ++ j;
            }
        }
    }
}