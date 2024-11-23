public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length !=goal.Length){return false;}

         string answer = s + s;
        return answer.Contains(goal);

        
    }
}


/*  

        int shift=0;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]==goal[0])
            {
                shift=i;
                break;
            }
        }
        string ans="";
        for(int i=shift;i<s.Length;i++)
        {
            ans+=s[i];
        }
        for(int i=0; i<shift;i++)
        {
            ans+=s[i];
        }
        if(ans==goal)
        {
            return true;
        }else
        {return false;}

*/