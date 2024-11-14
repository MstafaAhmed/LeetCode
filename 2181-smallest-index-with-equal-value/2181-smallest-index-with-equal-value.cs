public class Solution {
    public int SmallestEqual(int[] nums) {
        int ans=-1;

        int []mod=new int[nums.Length];

        for(int i=0;i<nums.Length;i++)
        {
            mod[i]=i%10;
        }
       

        for(int i=0;i<nums.Length;i++)
        {
            if(mod[i]==nums[i])
            {
                ans=i;
                break;
                
            }
        }        
        
        return ans;
    }
}