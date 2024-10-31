public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int move=0;  // intialize the number of move to zero

        //use nasted loop 
        for(int i=0;i<s.Length;i++)
        {
            for(int j=0;j<t.Length;j++)
            {
                // chacking 
                if (s[i]==t[j])
                {
                    //calculate absolute value of move
                    if(i>j)
                    { 
                        move+=(i-j);
                    }else
                    {
                        move+=(j-i);
                    }
                }


            }
        }
        return move;
        
    }
}