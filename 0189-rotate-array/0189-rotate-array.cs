public class Solution {
    public void Rotate(int[] nums, int k) {
        if (k == 0 || nums.Length == 1 || nums.Length == k)
			{return;}
        
        int[] tmp=new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            tmp[(i+k)%nums.Length]=nums[i];
        }
         for(int i =0;i<nums.Length;i++)
        {
            nums[i]=tmp[i];            
        }
    }
}