public class Solution {
    public bool IsPowerOfThree(int n) {
           if(n == 1)
        {
            return true;
        }else if (n<=0)
        {
            return false;
        }
       
        if(n%3!=0)
        {
            return false;
        }   
   
         while(n%3==0)
        { 
            n/=3;    
          
        }
         return n==1;  
        
    }
}