public class Solution {
    public string ReverseWords(string s) {
        string ans="";
        int L=0;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]==' ')
            {
                for(int j=i-1;j>=L;j--)
                {
                    ans+=s[j];
                }
                ans+=' ';
                L=i+1;
            }
        }
                
               for(int j=s.Length-1;j>L-1;j--)
                {
                    ans+=s[j];
                }

        return ans;
        
    }
}