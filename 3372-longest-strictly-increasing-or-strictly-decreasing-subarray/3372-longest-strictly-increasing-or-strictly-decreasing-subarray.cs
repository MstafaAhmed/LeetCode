public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int increase=0;
        int temp=0;

        for(int i=0;i<nums.Length-1;i++)
        {
            if(nums[i]<nums[i+1])
            {
                temp++;
                  if(temp>increase)
                {increase=temp;}
            }else
            {
              
                temp=0;
            }
        }
        int decrease=0;
        temp=0;

        for(int i=0;i<nums.Length-1;i++)
        {
            if(nums[i]>nums[i+1])
            {
                temp++;
                if(temp>decrease)
                {decrease=temp;}
            }else
            {
                
                temp=0;
            }
        }
        if(decrease>increase)
        {
            return decrease+1;
        }else
        {return increase+1;}

        
    }
}