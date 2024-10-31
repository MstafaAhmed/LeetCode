public class Solution {
    public int MaxProduct(int[] nums) {

    int answer=0;

    for(int i=0;i<nums.Length-1;i++)
    {
         int temp=0;
         // sorting the array to define two maximum numbers
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
    answer=(nums[0]-1)*(nums[1]-1);
    return answer;        
    }

}