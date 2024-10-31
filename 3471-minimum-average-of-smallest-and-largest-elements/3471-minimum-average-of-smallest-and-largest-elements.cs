public class Solution {
    public double MinimumAverage(int[] nums) {
        double []avg=new double[nums.Length/2];
        Array.Sort(nums);
        for(int i=0;i<nums.Length/2;i++)
        {
            avg[i]=(double)(nums[i]+nums[nums.Length-1-i])/2;

        }
        Array.Sort(avg);
        return avg[0];
        
    }
}