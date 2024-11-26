public class Solution {
    public bool IsBalanced(string num) {
        int sum_even=0;
        int sum_odd =0;

        for(int i=0;i<num.Length;i+=2)
        {
            sum_even+=num[i] - '0';
        }
        for(int i=1;i<num.Length;i+=2)
        {  
            sum_odd+=num[i]-'0';
        }
     
       return (sum_odd==sum_even);
        
    }
}