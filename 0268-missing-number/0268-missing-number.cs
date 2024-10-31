public class Solution {
    public int MissingNumber(int[] nums) {
        int ans=0;
   
        Array.Sort(nums);
       
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==ans)
            {
                ans++;
            }

        }
        return ans;
        
    }
}