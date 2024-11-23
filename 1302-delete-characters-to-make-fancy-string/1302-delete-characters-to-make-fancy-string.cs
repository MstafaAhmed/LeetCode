   public class Solution {
    public string MakeFancyString(string s) {
        if(s.Length<=2)
        {
            return s;
        }else{

        char[] ans = s.ToCharArray();
        //ans+=s[0];
        //ans+=s[1];
        int j=2;

        for(int i=2;i<s.Length;i++)
        {
            if(s[i]!=s[i-1] || (s[i]!=s[i-2]))
            {
                ans[j++]=ans[i];
            }
        }
        
         return new string(ans, 0, j);
        }
        
    }
}
      /*  if(s.Length<=2){return s;}
        else{
        string ans = "";
        ans+=s[0];
        ans+=s[1];
        for(int i=2;i<s.Length;i++)
        {
            if(s[i]!=s[i-1] || (s[i]!=s[i-2]))
            {    ans+=s[i];}
        }
           return ans;
        }       
    }
}
*/