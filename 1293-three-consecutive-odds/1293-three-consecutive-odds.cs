public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        if(arr.Length<3){return false;}
        int odd=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]%2==1)
            {
                odd++;
            }else
            {
                odd=0;
            }
            if(odd==3)
            {
                break;
            }

        }
        if(odd==3)
        {
            return true;
        }else
        {
            return false;
        }
        
    }
}