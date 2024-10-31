public class Solution {
    public bool ContainsDuplicate(int[] nums) {
         int temp=0;
        for(int i=0;i<nums.Length-1;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[i]==nums[j])
                {
                    temp=1;
                    break;
                }
            }
        }
        if(temp==1){
            return true;
            }else
            {return false;}
    }
}