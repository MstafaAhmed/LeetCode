public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {

       int []answer=new int[nums.Length]; // the answer stored in array answer

    // using nasted loop to check how many numbers in the array are smaller than it
       for(int i=0;i<nums.Length;i++)
       {
        int result=0;

        //find out how many numbers in the array are smaller than element of i
        for(int j=0;j<nums.Length;j++)
        {
            if(nums[i]>nums[j])
            {
                result++;
                // if number of nums[i] grater than number of nums[j] increase the result by one
            }
        }
        answer[i]=result;
       } 
    return answer;
    }
}