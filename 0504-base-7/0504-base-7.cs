public class Solution {
    public string ConvertToBase7(int num) {
        if(num<7 && num>=0){ return Convert.ToString(num);}
        string res="";
        int n=Math.Abs(num);
        int i=0;
        int sum=0;
        while(n!=0)
        {
            
            res+= Convert.ToString((n%7));
            n/=7;       
        }
        if(num<0){res+="-";}
          res = new string(res.Reverse().ToArray());
       

        return res;       
    }
}