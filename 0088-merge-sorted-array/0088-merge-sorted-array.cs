public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

         if(n==0){return;}
        for(int i=0;i<n;i++)
        {
            nums1[m+i]=nums2[i];
        }
        
        int temp=0;
        for(int i=0;i<nums1.Length-1;i++)
        {
            for(int j=i+1;j<nums1.Length;j++)
            {
                if(nums1[i]>nums1[j])
                {
                    temp=nums1[i];
                    nums1[i]=nums1[j];
                    nums1[j]=temp;
                }
            }
        }
    }
}