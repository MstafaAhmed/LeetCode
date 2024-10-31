public class Solution {
    public int CalPoints(string[] operations) {
        int[]nums =new int [operations.Length];
    int j=0;
        for(int i=0;i<operations.Length;i++)
        {
            if(operations[i]=="+")
            {
                nums[j]=nums[j-1]+nums[j-2];
                j++;
            }else if(operations[i]=="D")
            {
                nums[j]=nums[j-1]*2;
                j++;
            }else if(operations[i]=="C")
            {
                j--;
            }else
            {
                nums[j]=int.Parse(operations[i]);
                j++;
            }
        }
        int sum=0;
        for(int i=0;i<j;i++)
        {
            sum+=nums[i];

        }
        return sum;
    }
}