public class Solution {
    public int SmallestEvenMultiple(int n) {
       int multiple;
            if(n%2==0)
            {
                multiple=n;
            }
            else
            {
                 multiple=n*2;

            }
                   
        return multiple;
    }
}