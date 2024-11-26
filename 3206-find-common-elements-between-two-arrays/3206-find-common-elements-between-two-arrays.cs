public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        int []ans=new int[2];
        ans[0]=0;
        ans[1]=0;

        for(int i=0;i<nums1.Length;i++)
        {
            for(int j=0;j<nums2.Length;j++)
            {
                if(nums1[i]==nums2[j])
                {
                    ans[0]=ans[0]+1;
                    break;
                }   
            }
        }

        for(int i=0;i<nums2.Length;i++)
        {
            for(int j=0;j<nums1.Length;j++)
            {
                if(nums2[i]==nums1[j])
                {
                    ans[1]++;
                    break;
                }   
            }
        }
        return ans;        
    }
}