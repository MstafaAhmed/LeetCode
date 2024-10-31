public class Solution {
    public int NumIdenticalPairs(int[] nums)
    {
        int sum=0;
        for(int i=1;i<nums.Length;i++)
        {
            for(int j=0;j<i;j++)
            {
                if(nums[j]==nums[i])
                {
                    sum++;
                }

            }
        }
    return sum;

    }
}