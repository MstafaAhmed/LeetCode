public class Solution {
    public int MinimumOperations(int[] nums) {
        int ans=0;
        for(int i=0;i<nums.Length;i++)
        {
            if((nums[i]-1)%3==0  || (nums[i]+1)%3==0)
            {
                ans++;
            }
            
        }
        return ans;
    }
}