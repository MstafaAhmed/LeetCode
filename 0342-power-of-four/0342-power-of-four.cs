public class Solution {
    public bool IsPowerOfFour(int n) {
        if(n == 1)
        {
            return true;
        }else if (n<=0)
        {
            return false;
        }
       
        if(n%4!=0)
        {
            return false;
        }   
   
         while(n%4==0)
        { 
            n/=4;    
          
        }
         return n==1;             

    }
}