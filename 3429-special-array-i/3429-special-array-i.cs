public class Solution {
    public bool IsArraySpecial(int[] nums) {
        if(nums.Length==1)
        {
            return true;
        }
        bool ans = true;
        for(int i=1;i<nums.Length;i++)
        {
            if((nums[i]%2) == (nums[i-1]%2))
            {
                ans=false;
                break;
            }
        }
        return ans;
    }
}