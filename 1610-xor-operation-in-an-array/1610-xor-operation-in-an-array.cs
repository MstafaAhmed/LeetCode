public class Solution {
    public int XorOperation(int n, int start) {
        int []nums=new int[n];
        nums[0]=start;
        int ans=start;

        for(int i=1;i<n;i++)
        {
            nums[i]=start+2*i;
            ans^=nums[i];
        }
        return ans;        
    }
}