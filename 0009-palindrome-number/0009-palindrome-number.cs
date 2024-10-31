public class Solution {
    public bool IsPalindrome(int x) {
        int n=x;
        int reverse=0;
        int reminder=0;
        if(x<0)
        {
            return false;
        }
        
            while(n!=0)
            {
                reminder = n%10;
                reverse=reverse*10+reminder;
                n/=10;

            }
            
        
        if(reverse==x)
        {
            return true;
        }else
        {
            return false;
        }
        
    }
}