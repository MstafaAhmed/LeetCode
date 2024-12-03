public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder afterSpace = new StringBuilder();
        int spaceIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (spaceIndex<spaces.Length && i == spaces[spaceIndex])
            {
                afterSpace.Append(' ');
                spaceIndex++;
            }
            afterSpace.Append(s[i]);
        }
        return afterSpace.ToString();
    }
}