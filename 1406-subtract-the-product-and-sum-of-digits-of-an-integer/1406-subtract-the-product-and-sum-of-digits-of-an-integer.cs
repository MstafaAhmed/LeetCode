public class Solution {
    public int SubtractProductAndSum(int n) {
        int product=1;
        int sum=0;
        int temp=0;

        while(n>9)
        {
            temp=n%10;
            sum+=temp;
            product*=temp;
            n=n/10;
        }

        return (n*product-(sum+n));
    }
}