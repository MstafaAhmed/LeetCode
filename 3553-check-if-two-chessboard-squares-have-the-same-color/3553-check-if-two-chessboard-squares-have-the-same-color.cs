public class Solution {
    public bool CheckTwoChessboards(string cd1, string cd2) {
        if(cd1==cd2){return true;}

      return (cd1[0] + cd1[1] + cd2[0] + cd2[1]) % 2 == 0;        
    }
}