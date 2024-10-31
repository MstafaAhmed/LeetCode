public class Solution {
    public int MinElement(int[] nums) {
       int[] digitSum=new int[nums.Length] ;
       for(int i=0;i<nums.Length;i++)
       {    
       while(nums[i] > 0) 
       {
            digitSum[i] += nums[i] % 10;
            nums[i] /= 10;
       }
       }
       return digitSum.Min();     


        
    }
}