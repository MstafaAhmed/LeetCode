public class Solution {
    public int ArraySign(int[] nums) {
        Array.Sort(nums);
        if (nums.Contains(0)){
            return 0;
        }
        int count=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]<0)
            {
                count++;
            }else
            {
                break;
            }
        }
        if(count%2==0){
            return 1;
        }else{
            return -1;
        }            
    }
}