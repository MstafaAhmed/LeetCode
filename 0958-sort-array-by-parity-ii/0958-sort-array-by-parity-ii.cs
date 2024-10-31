public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        Array.Sort(nums);
        int[]ans=new int[nums.Length];
       int j=0;
       int k=1;
      
       for(int i=0;i<nums.Length;i++)
       {
        if(nums[i]%2==0)
        {
            ans[j]= nums[i];
            j++;
        }else
        {
            ans[(nums.Length)-k]=nums[i];
            k++;
        }
       }
       int z=0;
       int m=0;
       int n=nums.Length/2;
       for(int i=0;i<nums.Length/2;i++)
       {
        nums[m]=ans[z];
        z++;
        m++;
        nums[m]=ans[n];
        n++;
        m++;

       }
        return nums;     
    }
}