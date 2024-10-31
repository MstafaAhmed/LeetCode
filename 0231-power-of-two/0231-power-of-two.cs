public class Solution {
    public bool IsPowerOfTwo(int n) {
        double power=2;
        int counter=1;
        if(n==1)
        {
            return true;
        }
        else if(n%2!=0)
        {
            return false;
        }else {
        while(n>power)
        {
           power=Math.Pow(2, counter);
           counter++;
        }
            if(power>n)
            {
                return false;
                
            }else 
            {
                return true;
            }
        }     
           


        
    }
}