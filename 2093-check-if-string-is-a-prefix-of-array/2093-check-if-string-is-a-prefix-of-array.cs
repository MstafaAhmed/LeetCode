public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        string res="";
        for(int i=0;i<words.Length;i++)
        {
            res+=words[i];
             if(s==res)
            {
                break;
            }
        }
        if(s==res)
        {
            return true;
        }else
        {
            return false;
        }
    }
}