public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int sum=0;
        int sumdigit=0;
        int temp=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i];
            while(nums[i]>0)
            {
                temp=nums[i]%10;
                sumdigit+=temp;
                nums[i]/=10;
            }
        }
        if(sum>sumdigit)
        {
            return (sum-sumdigit);
        }else
        {
            return (sumdigit-sum);
        }
        
    }
}