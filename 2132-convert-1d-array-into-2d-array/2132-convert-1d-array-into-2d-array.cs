public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if(m*n != original.Length){return [];}
        int[][]ans=new int[m][];
        int x=0;
        for(int i=0;i<m;i++)
        {
            ans[i]=new int[n];
            for(int j=0;j<n;j++)
            {
                ans[i][j]=original[x];
                x++;
            }
        }
        return ans;

        
    }
}