public class Solution {
    public int Tribonacci(int n) {
        int Tn=0;
        int T0=0;
        int T1=1;
        int T2=1;
        
        if(n<=2 && n>0)
        {
            Tn=1;
        }else if(n==0)
        {
            Tn=0;
        }
        for(int i=2;i<n;i++)
        {
            
            Tn=T0+T1+T2;
            T0=T1;
            T1=T2;
            T2=Tn;
        }


        return Tn;
    }
}