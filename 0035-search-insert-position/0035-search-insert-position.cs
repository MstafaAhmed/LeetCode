public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int ans=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==target)
            {
                ans=i;
            }else if(target>nums[i])
            {
                ans=i+1;

            }
        }
        return ans;
    }
}