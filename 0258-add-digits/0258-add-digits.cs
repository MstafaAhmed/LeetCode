public class Solution {
    public int AddDigits(int num) {
        int rem=0;
    
        do
        {
            rem=num%10;
            num/=10;
            num=rem+num;

        }while(num>9);
        return (num);
        
    }
}