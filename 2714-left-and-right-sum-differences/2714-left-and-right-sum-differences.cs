public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        
        int[] leftSum = new int[nums.Length];  //an array to calculate the sum of elements to the left 
        int[] rightSum = new int[nums.Length];//an array to calculate the sum of elements to the right 
        int[] answer = new int[nums.Length];  // array of result
   
            leftSum[0] = 0;    // the first element of left sum array =0
            
            for(int j = 1; j<=nums.Length-1; j++)
            {
                leftSum[j] = leftSum[j-1] + nums[j-1];
            }

            rightSum[nums.Length - 1] = 0; // the last element of right sum =0

            for(int k = nums.Length-2; k >=0 ; k--)
            {
                rightSum[k] = rightSum[k+1] + nums[k+1];
            }

            // check which is greater 
        for(int i=0; i<nums.Length; i++)
        {
            if(leftSum[i] >= rightSum[i])
            {
                answer[i] = leftSum[i] - rightSum[i];
            }
            else
            {
                answer[i] = rightSum[i] - leftSum[i];
            }
        }
        return answer;
    }
}