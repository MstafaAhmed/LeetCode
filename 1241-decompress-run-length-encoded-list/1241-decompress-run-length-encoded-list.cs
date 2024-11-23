public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> result = new List<int>();

        for(int i = 0;i < nums.Length/2; i++)
        {
            for(int j=0;j < nums[2*i]; j++)
            {
                result.Add(nums[(2*i)+1]);
            }
        }
        return result.ToArray();
    }
}