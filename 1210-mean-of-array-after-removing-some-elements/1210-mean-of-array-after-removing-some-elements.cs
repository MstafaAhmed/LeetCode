public class Solution {
    public double TrimMean(int[] arr) {
        Array.Sort(arr);
        int length=(arr.Length)/20;
        double ans=0;
        for(int i=length;i<(arr.Length-length);i++)
        {
            ans+=arr[i];
        }
        ans/=(arr.Length-length*2);
        return ans;
        
    }
}