public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] arr = new int[2];
        int x=0;
        for(int i=0;i<nums.Length-1;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[i]==nums[j])
                {
                    arr[x]=nums[i];
                    x++;
                }
            }
        }
        return arr;
    }
}