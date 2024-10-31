public class Solution {
    public int DominantIndex(int[] nums) {

       int maxValue = nums.Max(); // Get the maximum value
        int maxIndex = Array.IndexOf(nums, maxValue); 
        Array.Sort(nums);
        if(maxValue<nums[nums.Length-2]*2)
        {
            return -1;
        }
        else{
            return maxIndex;
            }        
        
    }
}