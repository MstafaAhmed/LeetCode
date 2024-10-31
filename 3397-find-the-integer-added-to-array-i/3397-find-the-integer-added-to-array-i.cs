public class Solution {
    public int AddedInteger(int[] nums1, int[] nums2) {
        
    int answer=0;

    for(int i=0;i<nums1.Length-1;i++)
    {
         int temp=0;
         // sorting the array to define two maximum numbers
         for(int j=i+1;j<nums1.Length;j++)
         {
            if(nums1[i]<nums1[j])
            {
                temp=nums1[i];
                nums1[i]=nums1[j];
                nums1[j]=temp;

            }
            
            if(nums2[i]<nums2[j])
            {
                temp=nums2[i];
                nums2[i]=nums2[j];
                nums2[j]=temp;

            }
         }

    }
    answer = nums2[0]-nums1[0];
    return answer;  
        
    }
}