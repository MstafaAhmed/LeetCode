public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int ans=0;

        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){continue;}
            int result=1;
            for(int j=i+1;j<nums.Length;j++)    
            {
                if(nums[j]==1)
                {
                    result++;
                }else
                {
                    break;
                }
            }    
            if(result>ans){ans=result;}
        }
        return ans;
    }
}