public class Solution {
    public int CountQuadruplets(int[] nums) {
       // Array.Sort(nums);
        int res=0;
        int sum=0;
        for(int i=0;i<nums.Length-3;i++)
        {
            for(int j=i+1;j<nums.Length-2;j++)
            {
                
                for(int k=j+1;k<nums.Length-1;k++)
                {
                    
                    for(int z=k+1;z<nums.Length;z++)
                    {
                        if(nums[i]+nums[j]+nums[k]==nums[z])
                       { res++;}
                    }
                }
            }

        }
        return res;
        
    }
}