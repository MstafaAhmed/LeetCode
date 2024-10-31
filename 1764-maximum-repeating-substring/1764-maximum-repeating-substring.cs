public class Solution {
    public int MaxRepeating(string sequence, string word) {

    if (sequence.Length < word.Length || sequence.Length == word.Length)
          {  return sequence != word ? 0 : 1;}

        int ans=0;
        string repeated=word;
    
         while (true)
            if (sequence.Contains(repeated))
            {
                ans++;
                repeated += word;
            }
            else
             {break;}
             
             return ans;       
    }
}