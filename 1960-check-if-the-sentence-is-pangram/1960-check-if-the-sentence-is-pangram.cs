public class Solution {
    public bool CheckIfPangram(string sentence) {
        var hashSet = new HashSet<char>(sentence);
        for (int i = 97; i <= 122; i++)
        {
            if(!hashSet.Contains((char)i))
                return false;
        }

        return true;
    }
}