public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length < 3) return nums.Max();

        var dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0],nums[1]);

        for (var i = 2; i < nums.Length; i ++){
            dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i -1]);
        }
        return dp[nums.Length -1];
    



/*
        int ans_odd=0;
        for(int i=0;i<nums.Length;i=i+2)
        {
            ans_odd+=nums[i];
        }
        int ans_even=0;
        for(int i=1;i<nums.Length;i=i+2)
        {
            ans_even+=nums[i];
        }
        if(ans_odd>ans_even)
        {
            return ans_odd;
        }else
        {return ans_even;}
      */  
        
    }
}