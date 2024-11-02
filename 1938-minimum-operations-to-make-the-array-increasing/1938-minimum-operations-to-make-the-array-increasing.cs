public class Solution {
    public int MinOperations(int[] nums) {
        if(nums.Length==1){return 0;}
        int ans=0;
        for(int i=0;i<nums.Length-1;i++)
        {  
            if(nums[i+1]<=nums[i])
            {
                ans+=nums[i]-nums[i+1]+1;
                nums[i+1]=nums[i]+1;
            }
        }
        return ans;
    }
}