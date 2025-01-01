public class Solution {
    public int MaxScore(string s) {
        
        int ones = 0; // Count total ones in the string
        int zeros = 0; // Count zeros in the left substring
        int ans = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
                ones++;
        }


        for (int i = 0; i < s.Length - 1; i++) { // Exclude the last split
            if (s[i] == '0') 
                zeros++;
            else
                ones--;
            ans = ans>zeros + ones ? ans: zeros + ones;
        }

        return ans;
    }
}