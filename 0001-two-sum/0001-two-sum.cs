public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
               int total;
               int x=0;
               int y=0;
               int j;
               total =0;

               for(int i=0;i<nums.Length -1 ;i++)
               {
                   
                for( j=i+1; j<nums.Length; j++ )
                 { 
                    total=nums[i]+nums[j];

                    if(total==target)
                    {
                        x=i;
                        y=j;

                    }
               }
                   


               }
               int[] z = {x,y} ;
               return z;
               //Console.WriteLine("["+ x + ","+y +"]");
    }
}