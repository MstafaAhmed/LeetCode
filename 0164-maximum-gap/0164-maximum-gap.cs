public class Solution {
    public int MaximumGap(int[] nums) {
        Array.Sort(nums);
        int ans=0;
        if(nums.Length<2)
        {
            return 0;
        }else
        {
            for(int i=0;i<nums.Length-1;i++)
            {
                if((nums[i+1]-nums[i])>ans)
                {
                    ans=nums[i+1]-nums[i];
                }
    
            }
        }
        return ans;
    }
}