public class Solution {
    public int FindPairs(int[] nums, int k) {
        var ans=new HashSet<int>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length-1;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(Math.Abs(nums[j]-nums[i])==k)
                {
                    ans.Add(nums[i]);
                    break;
                }
                 if(nums[j]-nums[i]>k)
                    break;
            }
        }
        
                return ans.Count;
    }
}