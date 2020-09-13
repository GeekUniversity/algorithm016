public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        
        int n = nums.Length;
        int head = 0;
        int tail = n - 1;
        
        var ans = new List<IList<int>>();
        
        for (int i = 0 ; i < n - 2; ++ i) {
            
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            head = i + 1;
            tail = n - 1;
            int curr = nums[i];
            
            while (head < tail) {
                int sum = nums[head] + nums[tail];
                if (sum + curr == 0) {
                    ans.Add(new List<int> { curr, nums[head], nums[tail] });
                    while (head < tail && nums[head] == nums[++ head]) ;
                    while (head < tail && nums[tail] == nums[-- tail]) ;
                } else if (sum + curr > 0) {
                    -- tail;
                } else {
                    ++ head;
                }
            }
        }
        
        return ans;
    }
}