public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        //if(x<10){return -1;}
        int comperator=x;
        int sum=0;
        while(x!=0)
        {
            sum+=(x%10);
            x/=10;
        }
        if(comperator%sum==0)
        {
            return sum;
        }else
        {
            return -1;
        }
          
        
    }
}