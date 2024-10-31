public class Solution {
    public string MergeAlternately(string word1, string word2) {
         
         string result ="";   // output of string type

         int i1=0;            // use i1 to access length of word1 
         
         int i2=0;             // use i2 to access length of word2

        // using while to add word1 + word2 where length of both is equal
         while(i1!=word1.Length && i2!=word2.Length)
        {
            result+=word1[i1];
            i1++;           // increment i1++ to acess te next letter in word1
         
            result+=word2[i2];
            i2++;           // increment i2++ to acess te next letter in word2
        }
        /* if the length of word1 is gteater than of length of word2 ,then the resut of result will be letter of word1 */
        while(i1!=word1.Length)
        {
            result+=word1[i1];
            i1++;
        }

               /* if the length of word2 is gteater than of length of word1 ,then the resut of result will be letter of word2 */

         while(i2!=word2.Length)
        {
            result+=word2[i2];
            i2++;
        }
        

        return result;
    }
}