public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[]arr = new int[nums.Length];
        
        for(int i=0;i<nums.Length;i+=2,n++)
        {
            arr[i]=nums[i/2];
            arr[i+1]=nums[n]; 
        
        }
        return arr;
    }
}