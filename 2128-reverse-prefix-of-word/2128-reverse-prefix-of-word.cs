public class Solution {
    public string ReversePrefix(string word, char ch) {
        int index=0;
        int x=1;
        while(x>0)
        {
            if(word[index]==ch)
            {
                x=-1;
            }else
            {
                index++;
            }
            if(index==word.Length)
            {
                x=-2;
            }
        }

       
       if(x==-2)
       {
        return word;
       }
       else
       {
        string ans="";
        for(int i=index;i>=0;i--)
        {
            ans += word[i];
        }
        for(int i=index+1;i<word.Length;i++)
        {
            ans+=word[i];
        }
        return ans;       
     }
   }
}