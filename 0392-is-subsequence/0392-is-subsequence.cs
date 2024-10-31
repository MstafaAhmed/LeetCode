public class Solution {
    public bool IsSubsequence(string s, string t) {
         int i=0,j=0;
        if(s.Length<1 )  return true;
        if(t.Length<1) return false;

        while(j<t.Length)
        {
            if(s[i]==t[j])
            {
                 i++;
            }
            if(i==s.Length) 
            {
                return true;
            }
            j++;
        }
        return false;
    }
}