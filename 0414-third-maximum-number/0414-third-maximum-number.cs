public class Solution {
    public int ThirdMax(int[] nums) {
     
     int temp=0;
     for(int i=0;i<nums.Length-1;i++)
     {
        for(int j=i+1;j<nums.Length;j++)
        {
            if(nums[i]<nums[j])
            {
                temp=nums[i];
                nums[i]=nums[j];
                nums[j]=temp;
            }
        }
     }
     
     int[] nums1 = nums.Distinct().ToArray();
     
        if(nums1.Length<3)
        {
            return nums1[0];
        }else
        {
            return nums1[2];
        }
        
    }
}