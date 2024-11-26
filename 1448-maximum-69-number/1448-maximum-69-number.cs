public class Solution {
    public int Maximum69Number (int num) {
        var n = num.ToString().ToArray();
         
        for(int i=0;i<n.Length;i++)
        {
            if(n[i]=='6')
            {
                n[i] = '9';
                break;
            }
        }
            return int.Parse(new string(n));       
    }
}