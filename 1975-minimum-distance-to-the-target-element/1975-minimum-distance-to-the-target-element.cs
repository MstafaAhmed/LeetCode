public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int abs=nums.Length;
        for(int i=0;i<nums.Length;i++)
        {
            int abs2=nums.Length;
            if(nums[i]==target)
            {
                abs2=Math.Abs(i-start);
                
            }
            if(abs>abs2)
            {
                abs=abs2;
            }
        }
        return abs;       
    }
}