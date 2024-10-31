public class Solution {
    public int TriangleNumber(int[] nums) {
        Array.Sort(nums);  // to ensure that nums[k]>=nums[j]>=nums[i]
        int ans=0;
        int sum=0;
        for(int i=0;i<nums.Length-2;i++)
        {
            for(int j=i+1;j<nums.Length-1;j++)
            {
            sum=nums[i]+nums[j];
                for(int k=j+1;k<nums.Length;k++)
                {
                  
                      if(nums[k]<sum) 
                      {
                        ans++;
                      }
                   }
           }
        }
        return ans;     
    }
}