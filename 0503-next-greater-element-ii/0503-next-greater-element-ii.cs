public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int n=nums.Length;
        int [] ans=new int[n];
        for(int i=0;i<n;i++)
        {
            ans[i]=-1;
        }
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<i+n;j++)
            {
                int index= j%n;
                if(nums[index]>nums[i])
                {
                    ans[i]=nums[index];
                    break;
                }
            }
        }
        return ans;
    }
}