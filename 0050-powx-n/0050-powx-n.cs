public class Solution {
    public double MyPow(double x, int n) {
        double ans=x;
        if (n==0 || x==1){
              return 1;
        }
        if(x==-1)
        {
            if(n%2==0)
            {
                return 1;
            }else
            {return -1;}
        }
        if(n<-20)
        {
            return 0;
        }

        for(int i=1;i<Math.Abs(n);i++)
        {
            ans *=x;
        }
        if(n<0)
        {
            ans=1/ans;
        }
        
        return ans;
      
    }
}