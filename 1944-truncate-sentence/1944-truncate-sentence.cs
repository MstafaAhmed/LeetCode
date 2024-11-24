public class Solution {
    public string TruncateSentence(string s, int k) {
        int sum=0;
        string ans="";
            for(int i=0;i<s.Length;i++)
            { 
                if(s[i]==' ')
                {
                    sum++;
                }
                if(sum==k)
                {
                    break;
                }
                ans+=s[i];
            }
        return ans;
    }
}