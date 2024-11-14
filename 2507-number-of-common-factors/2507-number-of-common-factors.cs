public class Solution {
    public int CommonFactors(int a, int b) {

        int count =0;
        int swap=0;
        if(a>b)
        {
            swap=b;
            b=a;
            a=swap;
        }

        for(int i=1;i<=a;i++)
        {
            if(a%i==0 && b%i==0)
            {
                count++;
            }
        }
            return count;
        
    }
}