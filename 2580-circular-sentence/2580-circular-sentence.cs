public class Solution {
    public bool IsCircularSentence(string sentence) {
        if(sentence[0]!=sentence[sentence.Length-1])
        {
            return false;
        }
        int ans=1;
        for(int i=1;i<sentence.Length-1;i++)
        {
            if (sentence[i] == ' ')
            {
                if (sentence[i-1] != sentence[i+1])
                {  
                    ans=0;
                    break;
                }
            }
        }
        if(ans==0)
        {
            return false;
        }else
        {return true;}
        
  }
              
}