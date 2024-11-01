public class Solution {
    public int NumberOfChild(int n, int k) {
         
       int result = 0;
        int direction = (k / (n - 1)) % 2;
        if(direction == 0)
        {
            return k % (n - 1);
        }
        else
        {
            return n - 1 - (k % (n - 1));
        }

        return result;  
       
        
    }
}