public class Solution {
    public int Fib(int n) {
        int Tn=0;
        int T0=0;
        int T1=1;
        if(n>2)
        {
            for(int i=1;i<n;i++)
            {
                Tn=T1+T0;
                T0=T1;
                T1=Tn;
            }
        }else if(n==2 || n==1)
        {
            Tn=1;
        }else
        {
            Tn=0;
        }
        return Tn;
    }
}