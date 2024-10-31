public class Solution {
    public int LargestAltitude(int[] gain) {
        int [] altitudes=new int[gain.Length+1];
        altitudes[0]=0;
      
        for(int i=1;i<gain.Length+1;i++)
        {
            altitudes[i]=altitudes[i-1]+gain[i-1];
        }

        for(int i=0;i<altitudes.Length-1;i++)
        {
            int temp;
            for(int j=i+1;j<altitudes.Length;j++)
            {
                if(altitudes[i]<altitudes[j])
                {
                    temp=altitudes[i];
                    altitudes[i]=altitudes[j];
                    altitudes[j]=temp;

                }
            }

        }
        return altitudes[0];
    }
}