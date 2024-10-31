public class Solution {
    public bool CanAliceWin(int[] nums) {

        int singleSum=0;
        int doubleSum=0;

        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]<10)
            {
                singleSum += nums[i]; 
            }else
            {
                doubleSum+=nums[i];

            }
        }
/*Alice wins if the sum of all single-digit numbers and the sum of all double-digit numbers are different that means they are not equal.*/
        if(doubleSum != singleSum)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}