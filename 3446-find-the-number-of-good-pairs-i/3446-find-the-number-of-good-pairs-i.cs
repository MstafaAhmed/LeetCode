public class Solution {
    public int NumberOfPairs(int[] nums1, int[] nums2, int k) {
        int good_pair=0;
        for(int i=0;i<nums1.Length;i++)
        {
            for(int j=0;j<nums2.Length;j++)
            {
                if( nums1[i]%(nums2[j]*k)==0 )
                {
                    good_pair++;
                }
            }

        }


        return good_pair;
    }
}