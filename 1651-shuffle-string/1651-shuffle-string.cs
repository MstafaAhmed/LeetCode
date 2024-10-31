public class Solution {
    public string RestoreString(string s, int[] indices) {
        
        char[] charArr = new char[s.Length];

        for(int i = 0; i < charArr.Length; i++)
        {
            charArr[indices[i]] = s[i];
        }

        return new string(charArr);
    }
}