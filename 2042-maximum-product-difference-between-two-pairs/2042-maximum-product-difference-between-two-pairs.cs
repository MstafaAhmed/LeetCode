public class Solution {
    public int MaxProductDifference(int[] nums) 
    {
            int answer=0;

    for(int i=0;i<nums.Length-1;i++)
    {
         int temp=0;
         //sorting the array to define max and min numbers
         for(int j=i+1;j<nums.Length;j++)
         {
            if(nums[i]<nums[j])
            {
                temp=nums[i];
                nums[i]=nums[j];
                nums[j]=temp;

            }
         }

    }
    answer=(nums[0]*nums[1])-(nums[nums.Length-1]*nums[nums.Length-1-1]);
    return answer;        
 
        
    }
}