public class Solution {
    public bool IsGood(int[] nums) {
        Array.Sort(nums);
        int n=nums.Length;
        int ans=1;
        if(n==1){return false;}

          for(int i=0;i<n-1;i++)
           {
            if(nums[i]/(i+1)!=1)
            {
                ans=0;
                break;
            }
           }

           if( ans==1 &&nums[n-1]==nums[n-2] &&  nums[n-1]==(n-1))
            {
                return true;
            }else {return false;}
            
    }
}