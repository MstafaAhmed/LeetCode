public class Solution {
    public string ConvertToBase7(int num) {
        if(num<7 && num>=0)
        {
           return Convert.ToString(num);
        }
        string res="";
        int Abs_num=Math.Abs(num);
        while(Abs_num!=0)
        {    
            res+= Convert.ToString(Abs_num%7);
            Abs_num/=7;       
        }
        if(num<0)
        {
            res+="-";
        }
        res = new string(res.Reverse().ToArray()); 
        return res;       
    }
}