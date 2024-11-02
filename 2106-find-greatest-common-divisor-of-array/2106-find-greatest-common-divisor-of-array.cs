public class Solution {
    public int FindGCD(int[] nums) {
        Array.Sort(nums);

    int res=1;
        for(int i=nums[0];i>1;i--)
        {
            if(nums[0]%i==0 && nums[nums.Length-1]%i==0)
            {
                res=i;
                break;
            }

        }
        return res;
        
    }
}