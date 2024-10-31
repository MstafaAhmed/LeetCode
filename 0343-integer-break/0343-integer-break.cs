public class Solution {
    public int IntegerBreak(int n) {
        if (n == 2 || n == 3) return (n-1);
        int mul=1;
        while(n>4)
        {
            n=n-3;
            mul=mul*3;
        }
        return mul=mul*n;
 
    }
}