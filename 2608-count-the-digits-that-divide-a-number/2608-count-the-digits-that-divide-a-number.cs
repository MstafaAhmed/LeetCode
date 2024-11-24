public class Solution {
    public int CountDigits(int num) {        
        int n=num;
        int ans=0;
        int temp=0;
        while(n>0)
        {
            temp=n%10;
            n/=10;
            if(num%temp==0)
            {
                ans++;
            }
        }
        return ans;
    }
}