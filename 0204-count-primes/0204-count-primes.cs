public class Solution {
    public int CountPrimes(int n) {
        /*if(n<=2)
        {return 0;}
        int ans=1;
        for(int i=3;i<n;i++) {
            if(i%2==0){continue;}
            int res=1;
            for(int j=2;j*j<=(i);j++)
            {
                if(i%j==0)
                {
                        res=0;
                        break;
                }
            }
            ans+=res;
        }

        return ans;*/
        
        bool[] prime = new bool[n];
        for (int i=0; i < n; i++) 
        {prime[i] = true;}        
        for (int i=2; i*i < n;i++)
        {
            if (prime[i] == true)
            {
                for (int j = i * i; j < n; j += i) 
                {
                    prime[j] = false;
                }
            }
        }
        int count = 0;
        for(int i=2;i< n; i++) {
            if (prime[i] == true) count++;
        }
        return count;


    }
}