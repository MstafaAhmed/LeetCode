public class Solution {
    public int MaximumWealth(int[][] accounts) {        
        int[] sum = new int[accounts.Length];
        int add;
        for(int i=0;i<accounts.Length;i++){
            add=0;
            for(int j=0;j<accounts[i].Length;j++)
            {
                add=add+accounts[i][j];

            }
            sum[i]=add;

        }
        return sum.Max();
        
    }
}