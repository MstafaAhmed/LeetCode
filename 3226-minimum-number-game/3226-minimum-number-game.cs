public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        int swap=0;

        for(int i=0;i<nums.Length;i++)
        {
            swap=nums[i];
            nums[i]=nums[i+1];
            nums[i+1]=swap;
            i++;
        }
        return nums;
        
    }
}